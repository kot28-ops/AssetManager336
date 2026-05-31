using System;
using System.Data;
using System.Windows.Forms;

namespace InvestmentAssetManager
{
    public partial class Form1 : Form
    {
        // Клієнт зберігає лише компоненти відображення
        private BindingSource clientBinder = new BindingSource();
        private DataTable uiTableCache;

        // Посилання на "віддалений" сервер бізнес-логіки
        private AssetDataEngine serverCore = new AssetDataEngine();

        public Form1()
        {
            InitializeComponent();
        }

        // Запуск форми (Подія Load, яку ми зв'язали минулого разу)
        private void Form1_Load_1(object sender, EventArgs e)
        {
            SyncDataWithServer();
        }

        // Клієнт звертається до сервера за даними
        private void SyncDataWithServer()
        {
            try
            {
                // Тонкий клієнт не знає SQL-запитів, він просто викликає метод сервера
                uiTableCache = serverCore.FetchFinancesRegistry();

                clientBinder.DataSource = uiTableCache;
                gridAssets.DataSource = clientBinder;

                if (gridAssets.Columns["SYMBOL"] != null) gridAssets.Columns["SYMBOL"].HeaderText = "Тікер акції";
                if (gridAssets.Columns["CO_NAME"] != null) gridAssets.Columns["CO_NAME"].HeaderText = "Назва компанії";
                if (gridAssets.Columns["CUR_PRICE"] != null) gridAssets.Columns["CUR_PRICE"].HeaderText = "Поточна вартість ($)";
                if (gridAssets.Columns["EXCHANGE"] != null) gridAssets.Columns["EXCHANGE"].HeaderText = "Біржа торгування";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка тонкого клієнта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 1. Кнопка "Оновити таблицю"
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SyncDataWithServer();
        }

        // 2. Кнопка "Додати запис"
        private void btnAddNewRow_Click(object sender, EventArgs e)
        {
            clientBinder.AddNew();
        }

        // 3. Кнопка "Фіксувати зміни"
        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                gridAssets.EndEdit();
                clientBinder.EndEdit();

                // Передаємо змінену локальну таблицю на сервер для збереження
                serverCore.CommitChangesToServer(uiTableCache);
                MessageBox.Show("Дані успішно оброблені сервером додатків!", "Тонкий клієнт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Збій транзакції", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Кнопка "Видалити рядок"
        private void btnRemoveAsset_Click(object sender, EventArgs e)
        {
            if (gridAssets.CurrentRow != null)
            {
                gridAssets.Rows.RemoveAt(gridAssets.CurrentRow.Index);
            }
        }

        // 5. Кнопка "Знайти"
        private void btnSearchExecute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchTicker.Text))
            {
                clientBinder.Filter = string.Format("SYMBOL LIKE '%{0}%'", txtSearchTicker.Text);
            }
            else
            {
                clientBinder.RemoveFilter();
            }
        }

        // Меню File -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Меню Help -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Програмний комплекс: Asset Portfolio Manager (Тонкий клієнт)\n\n" +
                          "Розробник: студент групи 336 Шеметов І. С.\n" +
                          "Архітектура: Багатоланкова (Клієнт - Сервер додатків - СКБД)";
            MessageBox.Show(info, "Орієнтація системи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Підказки для кнопки "Оновити таблицю"
        private void btnLoadData_MouseEnter(object sender, EventArgs e) =>
            statusLabelInfo.Text = "Надсилання запиту до сервера додатків для отримання свіжих котирувань акцій.";
        private void btnLoadData_MouseLeave(object sender, EventArgs e) => statusLabelInfo.Text = "Система готова до роботи";

        // Підказки для кнопки "Додати запис"
        private void btnAddNewRow_MouseEnter(object sender, EventArgs e) =>
            statusLabelInfo.Text = "Генерація нового порожнього рядка в таблиці активів для ручного заповнення.";
        private void btnAddNewRow_MouseLeave(object sender, EventArgs e) => statusLabelInfo.Text = "Система готова до роботи";

        // Підказки для кнопки "Фіксувати зміни"
        private void btnSaveToDatabase_MouseEnter(object sender, EventArgs e) =>
            statusLabelInfo.Text = "Пакетна передача модифікованих клієнтом даних назад на сервер бізнес-логіки.";
        private void btnSaveToDatabase_MouseLeave(object sender, EventArgs e) => statusLabelInfo.Text = "Система готова до роботи";

        // Підказки для кнопки "Видалити рядок"
        private void btnRemoveAsset_MouseEnter(object sender, EventArgs e) =>
            statusLabelInfo.Text = "Позначення виділеного фінансового активу на видалення з поточної сесії.";
        private void btnRemoveAsset_MouseLeave(object sender, EventArgs e) => statusLabelInfo.Text = "Система готова до роботи";

        // Підказки для кнопки "Знайти"
        private void btnSearchExecute_MouseEnter(object sender, EventArgs e) =>
            statusLabelInfo.Text = "Миттєве сортування та фільтрація списку компаній за вказаним у полі тікером.";
        private void btnSearchExecute_MouseLeave(object sender, EventArgs e) => statusLabelInfo.Text = "Система готова до роботи";

        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо повний шлях до папки, де запущена наша програма
                string executionPath = AppDomain.CurrentDomain.BaseDirectory;

                // Піднімаємося до папки проекту і формуємо шлях до нашого index.html
                string htmlDocumentPath = System.IO.Path.Combine(executionPath, @"..\..\HelpSystem\index.html");

                // Запуск довідки у вікні браузера за замовчуванням
                System.Diagnostics.Process.Start(System.IO.Path.GetFullPath(htmlDocumentPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відкрити довідкову службу системи: " + ex.Message,
                                "Збій підсистеми Help", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
