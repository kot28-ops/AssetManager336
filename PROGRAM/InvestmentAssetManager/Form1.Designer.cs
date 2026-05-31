namespace InvestmentAssetManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridAssets = new System.Windows.Forms.DataGridView();
            this.txtSearchTicker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnAddNewRow = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnRemoveAsset = new System.Windows.Forms.Button();
            this.btnSearchExecute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridAssets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAssets
            // 
            this.gridAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAssets.Location = new System.Drawing.Point(60, 78);
            this.gridAssets.Name = "gridAssets";
            this.gridAssets.RowHeadersWidth = 51;
            this.gridAssets.RowTemplate.Height = 24;
            this.gridAssets.Size = new System.Drawing.Size(976, 241);
            this.gridAssets.TabIndex = 0;
            // 
            // txtSearchTicker
            // 
            this.txtSearchTicker.Location = new System.Drawing.Point(190, 37);
            this.txtSearchTicker.Name = "txtSearchTicker";
            this.txtSearchTicker.Size = new System.Drawing.Size(158, 28);
            this.txtSearchTicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фільтр за тікером:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(60, 337);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(179, 30);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Оновити таблицю";
            this.toolTip1.SetToolTip(this.btnLoadData, "Синхронізація з сервером");
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            this.btnLoadData.MouseEnter += new System.EventHandler(this.btnLoadData_MouseEnter);
            this.btnLoadData.MouseLeave += new System.EventHandler(this.btnLoadData_MouseLeave);
            // 
            // btnAddNewRow
            // 
            this.btnAddNewRow.Location = new System.Drawing.Point(272, 337);
            this.btnAddNewRow.Name = "btnAddNewRow";
            this.btnAddNewRow.Size = new System.Drawing.Size(142, 30);
            this.btnAddNewRow.TabIndex = 4;
            this.btnAddNewRow.Text = "Додати запис";
            this.toolTip1.SetToolTip(this.btnAddNewRow, "Створити новий актив");
            this.btnAddNewRow.UseVisualStyleBackColor = true;
            this.btnAddNewRow.Click += new System.EventHandler(this.btnAddNewRow_Click);
            this.btnAddNewRow.MouseEnter += new System.EventHandler(this.btnAddNewRow_MouseEnter);
            this.btnAddNewRow.MouseLeave += new System.EventHandler(this.btnAddNewRow_MouseLeave);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(676, 337);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(168, 30);
            this.btnSaveToDatabase.TabIndex = 5;
            this.btnSaveToDatabase.Text = "Фіксувати зміни";
            this.toolTip1.SetToolTip(this.btnSaveToDatabase, "Надіслати дані на сервер");
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            this.btnSaveToDatabase.MouseEnter += new System.EventHandler(this.btnSaveToDatabase_MouseLeave);
            this.btnSaveToDatabase.MouseLeave += new System.EventHandler(this.btnSaveToDatabase_MouseLeave);
            // 
            // btnRemoveAsset
            // 
            this.btnRemoveAsset.Location = new System.Drawing.Point(861, 337);
            this.btnRemoveAsset.Name = "btnRemoveAsset";
            this.btnRemoveAsset.Size = new System.Drawing.Size(175, 30);
            this.btnRemoveAsset.TabIndex = 6;
            this.btnRemoveAsset.Text = "Видалити рядок";
            this.toolTip1.SetToolTip(this.btnRemoveAsset, "Вилучити поточний рядок");
            this.btnRemoveAsset.UseVisualStyleBackColor = true;
            this.btnRemoveAsset.Click += new System.EventHandler(this.btnRemoveAsset_Click);
            this.btnRemoveAsset.MouseEnter += new System.EventHandler(this.btnRemoveAsset_MouseEnter);
            this.btnRemoveAsset.MouseLeave += new System.EventHandler(this.btnRemoveAsset_MouseLeave);
            // 
            // btnSearchExecute
            // 
            this.btnSearchExecute.Location = new System.Drawing.Point(354, 35);
            this.btnSearchExecute.Name = "btnSearchExecute";
            this.btnSearchExecute.Size = new System.Drawing.Size(115, 30);
            this.btnSearchExecute.TabIndex = 7;
            this.btnSearchExecute.Text = "Знайти";
            this.toolTip1.SetToolTip(this.btnSearchExecute, "Активувати фільтр");
            this.btnSearchExecute.UseVisualStyleBackColor = true;
            this.btnSearchExecute.Click += new System.EventHandler(this.btnSearchExecute_Click);
            this.btnSearchExecute.MouseEnter += new System.EventHandler(this.btnSearchExecute_MouseEnter);
            this.btnSearchExecute.MouseLeave += new System.EventHandler(this.btnSearchExecute_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contentToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelInfo
            // 
            this.statusLabelInfo.Name = "statusLabelInfo";
            this.statusLabelInfo.Size = new System.Drawing.Size(193, 20);
            this.statusLabelInfo.Text = "Система готова до роботи";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contentToolStripMenuItem.Text = "Content";
            this.contentToolStripMenuItem.Click += new System.EventHandler(this.contentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSearchExecute);
            this.Controls.Add(this.btnRemoveAsset);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnAddNewRow);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchTicker);
            this.Controls.Add(this.gridAssets);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Система контролю інвестиційних активів.";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridAssets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAssets;
        private System.Windows.Forms.TextBox txtSearchTicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnAddNewRow;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnRemoveAsset;
        private System.Windows.Forms.Button btnSearchExecute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelInfo;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
    }
}

