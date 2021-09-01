using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quality.Directory.addDirectortData
{
    class DatabaseDirectoryAdd
    {
        private string _dbName = "material_costumer_manufactur";
        private readonly string _table;
        private string _query;
        private readonly string _conn;

        public DatabaseDirectoryAdd(string table, string conn)
        {
            _conn = conn;
            _table = table;
        }

        public void InputData(string query)
        {
            _query = $"insert into `{_dbName}`.`{_table}` ";
            _query += query;
            Query();
        }

        public void UpdateData(string query)
        {
            _query = $"UPDATE `{_dbName}`.`{_table}` SET ";
            _query += query;
            Query();

        }

        private void Query()
        {
            using (MySqlConnection conn = new MySqlConnection(_conn))
            {
                MySqlCommand command = new MySqlCommand(_query, conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Message message = new Message();
                    message.sentMessage($"Произошла ошибка с подключением к базе данных {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
