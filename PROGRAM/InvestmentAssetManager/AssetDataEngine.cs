using System;
using System.Data;
using System.Data.SqlClient;

namespace InvestmentAssetManager
{
    // Цей клас виступає в ролі проміжного сервера додатків (бізнес-рівень)
    public class AssetDataEngine
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\labs\InvestmentAssetManager\InvestmentAssetManager\AssetData.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlDataAdapter _cryptoBridge;
        private SqlCommandBuilder _builder;

        // Метод зчитування даних (Сервер віддає готову таблицю клієнту)
        public DataTable FetchFinancesRegistry()
        {
            DataTable dataHolder = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string sqlQuery = "SELECT * FROM Finances";
                    _cryptoBridge = new SqlDataAdapter(sqlQuery, connection);
                    _builder = new SqlCommandBuilder(_cryptoBridge);
                    _cryptoBridge.Fill(dataHolder);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Сервер не зміг отримати дані: " + ex.Message);
            }
            return dataHolder;
        }

        // Метод збереження змін (Клієнт передає змінену таблицю на сервер)
        public void CommitChangesToServer(DataTable alteredTable)
        {
            try
            {
                // Для оновлення ініціалізуємо міст заново з тим самим запитом
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string sqlQuery = "SELECT * FROM Finances";
                    _cryptoBridge = new SqlDataAdapter(sqlQuery, connection);
                    _builder = new SqlCommandBuilder(_cryptoBridge);
                    _cryptoBridge.Update(alteredTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Сервер відхилив запис оновлень: " + ex.Message);
            }
        }
    }
}
