using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality.directory
{
    public partial class BaseFormDirectory : Form
    {
        private string _conn;
        private string _table;
        public BaseFormDirectory(string conn, string table)
        {
            _table = table;
            _conn = conn;
            InitializeComponent();
            this.Text = table;
            Database database = new Database(_conn, table, dataGridViewDirectory);
            NameColumns nameColumns = new NameColumns(dataGridViewDirectory, table);
            nameColumns.ChangesDisplayOfData();
        }
    }

    class Database
    {
        private string _dataBase = "material_costumer_manufactur";
        private DataGridView _dataGridViewDirectory;
        private string _conn;
        public Database(string conn,string table, DataGridView dataGridView)
        {
            _conn = conn;
            _dataGridViewDirectory = dataGridView;
            string query = "select * from " + _dataBase + "." + table + "";
            switch (table)
            {
                case "class":
                    GetDatabase(_dataBase,table, query);
                    break;
                case "group_material":
                    GetDatabase(_dataBase,table, query);
                    break;
                case "manufacturer":
                    GetDatabase(_dataBase,table, query);
                    break;
                case "mark":
                    GetDatabase(_dataBase,table, query);
                    break;
                case "material":
                    GetDatabase(_dataBase,table, query);
                    break;
                case "units":
                    GetDatabase(_dataBase,table, query);
                    break;
                default:
                    MessageBox.Show("Такую формы нету");
                    break;
            }
        }

        private void GetDatabase(string _database, string table, string query)
        {
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                mCon.Open();
                string sql = query;
                MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                DataSet ds = new DataSet();
                ds.Reset();
                dD.Fill(ds, sql);
                _dataGridViewDirectory.DataSource = ds.Tables[0];
                mCon.Close();
            }
        }
    }

    class NameColumns
    {
        private DataGridView _dataGridViewDirectory;
        private object[] _names = new object[0];
        private Dictionary<string, string> rename = new Dictionary<string, string>();
        private List<string> _invisibleElements = new List<string>();
        private string _table;

        public NameColumns(DataGridView dataGridView, string table)
        {
            _table = table;
            _dataGridViewDirectory = dataGridView;
            for (int i = 0; i < _dataGridViewDirectory.Columns.Count; i++)
            {
                object[] names = new object[_names.Length + 1];
                for (int j = 0; j < _names.Length; j++)
                {
                    names[j] = _names[j];
                }
                names[_names.Length] = _dataGridViewDirectory.Columns[i].HeaderText;
                _names = names;
            }
        }

        public void ChangesDisplayOfData()
        {
            switch (_table)
            {
                case "class":
                    rename.Add("name", "Название");
                    rename.Add("comments", "Коментарий");
                    _invisibleElements.Add("id");
                    break;
                case "group_material":

                    break;
                case "manufacturer":

                    break;
                case "mark":

                    break;
                case "material":

                    break;
                case "units":

                    break;
                default:
                    MessageBox.Show("Для такой формы нету визуальных изменений");
                    break;
            }
            RenamesColumns();
            ChangesTheVisibilityColumns();
        }

        private void RenamesColumns()
        {
            for (int i = 0; i < _dataGridViewDirectory.Columns.Count; i++)
            {
                for (int j = 0; j < rename.Count; j++)
                {
                    if (_dataGridViewDirectory.Columns[i].HeaderText == rename.ElementAt(j).Key)
                    {
                        _dataGridViewDirectory.Columns[i].HeaderText = rename.ElementAt(j).Value;
                    }
                }
            }
        }

        private void ChangesTheVisibilityColumns()
        {
            for (int i = 0; i < _dataGridViewDirectory.Columns.Count; i++)
            {
                for(int j = 0; j < _invisibleElements.Count; j++)
                {
                    if(_dataGridViewDirectory.Columns[i].HeaderText == _invisibleElements[j])
                    {
                        _dataGridViewDirectory.Columns[i].Visible = false;
                    }
                }
            }
        }

        public string[] GetBaseNamesColumns()
        {
            string[] names = new string[_names.Length];
            for (int i = 0; i < _names.Length; i++)
            {
                names[i] = _names[i].ToString();
            }
            return names;
        }

        public List<string> GetNamesColumns()
        {
            List<string> names = new List<string>();
            for(int i = 0; i < rename.Count; i++)
            {
                names.Add(rename.ElementAt(i).Value);
            }
            return names;
        }
    }
}
