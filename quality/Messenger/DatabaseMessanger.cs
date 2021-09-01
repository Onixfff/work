using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quality.Messenger
{
    class DatabaseMessanger
    {
        private string _database = "documents";
        private string _conn;
        private string _table;

        public DatabaseMessanger(string conn, string table)
        {
            _conn = conn;
            _table = table;
        }

        public void ChangeDataInDataGrid(DataGridView dataGridView, int typeMessage)
        {
            try
            {
                using (MySqlConnection mCon = new MySqlConnection(_conn))
                {
                    mCon.Open();
                    string sql = $"Select `messengers`.`id` as '№ Входящего', `date input` as 'Дата', `id carrier`, `carriers`.`name` as 'Носитель', `id type documents`, `types documents`.`type` as 'Тип', `id sender`, `senders`.`name` as 'Отправитель', `sender Number` as '№ Исх', `sender date` as 'Дата Исх', `id recipient`, `users`.`fam` as 'Получатель' from {_database}.{_table} left join documents.carriers on `id carrier` = 'carrier.id' left join documents.`types documents` on `id type documents` = `types documents`.`id` left join documents.`senders` on `id sender` = `senders`.`id` left join users.`users` on `id recipient` = `users`.`id` where (`type message` = {typeMessage})";
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    dataGridView.DataSource = ds.Tables[0];
                    mCon.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось загрузить данные с базы данных" + ex.Message);
            }
        }
    }
}
