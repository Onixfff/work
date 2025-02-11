using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quality.Messenger
{
    class DatabaseMessenger
    {
        private string _database = "documents";
        private string _conn;
        private string _table;

        public DatabaseMessenger(string conn, string table)
        {
            _conn = conn;
            _table = table;
        }
        /// <summary>
        /// Отдает словарь данных с ключами из названия столбцов и значениями этих столбцов.
        /// </summary>
        /// <param name="id">id для нахождение таблице в bd</param>
        /// <param name="typeMessage"> Тип сообщения </param>
        /// <returns></returns>
        public IReadOnlyDictionary<string, string> PostDataUpdate(string id, int typeMessage)
        {
            List<string> columnNamesList = new List<string>();
            List<string> rowsList = new List<string>();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                using (MySqlConnection mCon = new MySqlConnection(_conn))
                {
                    mCon.Open();
                    string sql =
                        $"select `messengers`.`id`, `date input`, `id carrier`, `carriers`.`name`, `id type documents`, `types documents`.`type`, `id sender`, `senders`.`name`, `sender Number`, `sender date`, `id recipient`, `users`.`fam`,`name documents`, `comment`, `id executor`, `users`.`fam`, `executor date of receiving`, `recipient number`, `outgoing date`, `control date`, `control mark`, `execution date`, `execution mark`, `location`, `number copies` from `{_database}`.`messengers` left join `{_database}`.`carriers` ON `id carrier` = `carriers`.`id` left join `{_database}`.`types documents` ON `id type documents` = `types documents`.`id` left join `{_database}`.`senders` ON `id sender` = `senders`.`id` left join `users`.`users` ON `id recipient` = `users`.`id` left join `users`.`users` as `executor name` ON `id executor` = `users`.`id` where (`type message` = '{typeMessage}' and `messengers`.`id` = '{id}')";
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    mCon.Close();
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataColumn column in dt.Columns)
                        {
                            columnNamesList.Add(column.ColumnName);
                        }

                        foreach (DataRow row in dt.Rows)
                        {
                            var cells = row.ItemArray;
                            foreach (object cell in cells)
                            {
                                rowsList.Add(cell.ToString());
                            }
                        }
                    }

                    for (int i = 0; i < columnNamesList.Count; i++)
                    {
                        dictionary.Add(columnNamesList[i], rowsList[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения данных для обновления\n" + ex.Message);
            }

            return dictionary;
        }

        /// <summary>
        /// Обновляет dataGridView используется для AdditionalDatabases.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="sql"></param>
        public void ChangeDataInDataGridView(DataGridView dataGridView, string sql)
        {
            try
            {
                using (MySqlConnection mCon = new MySqlConnection(_conn))
                {
                    mCon.Open();
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

        /// <summary>
        /// Обновляет DataGridView в зависимости от параметра typeMessage и все обновления вносит в передаваемый dataGridView.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="typeMessage"></param>
        public void ChangeDataInDataGridView(DataGridView dataGridView, int typeMessage)
        {
            try
            {
                using (MySqlConnection mCon = new MySqlConnection(_conn))
                {
                    mCon.Open();
                    string sql = $"Select `messengers`.`id` as '№ Входящего', `date input` as 'Дата', `id carrier`, `carriers`.`name` as 'Носитель', `id type documents`, `types documents`.`type` as 'Тип', `id sender`, `senders`.`name` as 'Отправитель', `sender Number` as '№ Исх', `sender date` as 'Дата Исх', `id recipient`, `users`.`fam` as 'Получатель' from {_database}.{_table} left join documents.carriers on `id carrier` = `carriers`.`id` left join documents.`types documents` on `id type documents` = `types documents`.`id` left join documents.`senders` on `id sender` = `senders`.`id` left join users.`users` on `id recipient` = `users`.`id` where (`type message` = {typeMessage})";
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    dataGridView.DataSource = ds.Tables[0];
                    mCon.Close();
                    dataGridView.Columns["id carrier"].Visible = false;
                    dataGridView.Columns["id type documents"].Visible = false;
                    dataGridView.Columns["id sender"].Visible = false;
                    dataGridView.Columns["id recipient"].Visible = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось загрузить данные с базы данных" + ex.Message);
            }
        }

        /// <summary>
        /// Составляет из словаря sql код для insert.
        /// </summary>
        /// <param name="dictionaryUserInput"></param>
        /// <param name="sqlFunction"></param>
        /// <returns></returns>
        private string SqlConverterCode(Dictionary<string,string> dictionaryUserInput, Enum sqlFunction)
        {
            switch (sqlFunction)
            {
                case SqlFunction.Insert:
                    string columnsNames = $"insert into `{_database}`.`{_table}` (";
                    string userInput = "values (";
                    for (var i = 0; i < dictionaryUserInput.Count; i++)
                    {
                        if (i != dictionaryUserInput.Count - 1)
                        {
                            columnsNames += $"`{dictionaryUserInput.ElementAt(i).Key}`,";
                            userInput += $"'{dictionaryUserInput.ElementAt(i).Value}',";
                        }
                        else
                        {
                            columnsNames += $"`{dictionaryUserInput.ElementAt(i).Key}`)";
                            userInput += $"'{dictionaryUserInput.ElementAt(i).Value}')";
                        }
                    }
                    return columnsNames + ' ' + userInput;
                case SqlFunction.Update:
                    string sqlCode = $"UPDATE `{_database}`.`{_table}` SET ";
                    string id = "";
                    for (var i = 0; i < dictionaryUserInput.Count; i++)
                    {
                        if (id == "")
                        {
                            id = dictionaryUserInput.ElementAt(i).Value.ToString();
                        }
                        else if (i != dictionaryUserInput.Count - 1)
                        {
                            sqlCode += $"`{dictionaryUserInput.ElementAt(i).Key.ToString()}` = '{dictionaryUserInput.ElementAt(i).Value.ToString()}', ";
                        }
                        else
                        {
                            sqlCode += $"`{dictionaryUserInput.ElementAt(i).Key.ToString()}` = '{dictionaryUserInput.ElementAt(i).Value.ToString()}' WHERE (`id` = '{id}');";
                        }
                    }
                    return sqlCode;
            }
            return "false";
        }

        /// <summary>
        /// Вызывает Функцию в InsertsOrUpdatesADatabase для добавления данных бд.
        /// </summary>
        /// <param name="dictionaryUserInput"></param>
        public void InsertData(Dictionary<string, string> dictionaryUserInput)
        {
            InsertsOrUpdatesADatabase(dictionaryUserInput, SqlFunction.Insert);
        }

        /// <summary>
        /// Вызывает Функцию в InsertsOrUpdatesADatabase для обновления бд.
        /// </summary>
        /// <param name="dictionaryUserInput"></param>
        public void UpdateData(Dictionary<string, string> dictionaryUserInput)
        {
            InsertsOrUpdatesADatabase(dictionaryUserInput, SqlFunction.Update);
        }

        /// <summary>
        /// Открывает соединение с бд и делает запрос к базе данных в зависимости от enum
        /// </summary>
        /// <param name="dictionaryUserInput"></param>
        /// <param name="sqlFunction"></param>
        private void InsertsOrUpdatesADatabase(Dictionary<string, string> dictionaryUserInput, Enum sqlFunction)
        {
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                try
                {
                    mCon.Open();
                    string sql = SqlConverterCode(dictionaryUserInput, sqlFunction);
                    MySqlCommand command = new MySqlCommand(sql, mCon);
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Message message = new Message();
                    message.sentMessage($"Произошла ошибка с подключением к базе данных {ex.Message}");
                }
                finally
                {
                    mCon.Close();
                }
            }
        }
    }
}
