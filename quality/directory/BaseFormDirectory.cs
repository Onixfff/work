using MySql.Data.MySqlClient;
using quality.Directory.addDirectortData;
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

        private void BaseFormDirectory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassDirectory formAdd = new ClassDirectory(_table, _conn);
            formAdd.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, string> dataChange = new Dictionary<string, string>();
            int coin = dataGridViewDirectory.SelectedRows.Count;
            List<string> nameElements = new List<string>() {"id","textBoxName", "richTextBoxComment", "", "richTextBoxComment" };
            for (int i = 0; i < coin; i++)
            {
                dataChange.Add("id", dataGridViewDirectory.SelectedRows[i].Cells[0].Value.ToString());
                dataChange.Add("textBoxName", dataGridViewDirectory.SelectedRows[i].Cells[1].Value.ToString());
            }
            switch (_table)
            {
                case "class":
                    for (int i = 0; i < coin; i++)
                    {
                        dataChange.Add("richTextBoxComment", dataGridViewDirectory.SelectedRows[i].Cells[2].Value.ToString());
                    }
                    break;
                case "group_material":
                    for (int i = 0; i < coin; i++)
                    {
                        dataChange.Add("richTextBoxComment", dataGridViewDirectory.SelectedRows[i].Cells[2].Value.ToString());
                    }
                    break;
                case "manufacturer":
                    for (int i = 0; i < coin; i++)
                    {
                        dataChange.Add("richTextBoxComment", dataGridViewDirectory.SelectedRows[i].Cells[2].Value.ToString());
                    }
                    break;
                case "mark":
                    for (int i = 0; i < coin; i++)
                    {
                        dataChange.Add("richTextBoxComment", dataGridViewDirectory.SelectedRows[i].Cells[2].Value.ToString());
                    }
                    break;
                case "material":
                    for (int i = 0; i < coin; i++)
                    {
                        dataChange.Add("richTextBoxComment", dataGridViewDirectory.SelectedRows[i].Cells[7].Value.ToString());
                        dataChange.Add("_textBoxShifr", dataGridViewDirectory.SelectedRows[i].Cells[2].Value.ToString());
                        dataChange.Add("_textBoxMaterial", dataGridViewDirectory.SelectedRows[i].Cells[5].Value.ToString());
                        dataChange.Add("_textBoxManufacturer", dataGridViewDirectory.SelectedRows[i].Cells[6].Value.ToString());
                        dataChange.Add("id_group", dataGridViewDirectory.SelectedRows[i].Cells[4].Value.ToString());
                        dataChange.Add("id_manifactur", dataGridViewDirectory.SelectedRows[i].Cells[3].Value.ToString());
                    }
                    break;
                case "units":
                    break;
                default:
                    MessageBox.Show("Такую формы нету");
                    break;
            }

            ClassDirectory formAdd = new ClassDirectory(_table, _conn, dataChange);
            formAdd.ShowDialog();
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
                    query = $"SELECT {_dataBase}.{table}.id, {_dataBase}.{table}.name, {_dataBase}.{table}.shifr, {_dataBase}.{table}.id_group, {_dataBase}.{table}.id_manifactur, {_dataBase}.group_material.name as 'Метериал', {_dataBase}.manufacturer.name as 'Производитель', {_dataBase}.{table}.comments FROM {_dataBase}.{table} LEFT JOIN {_dataBase}.group_material ON {table}.id_group = group_material.id LEFT JOIN {_dataBase}.manufacturer ON {table}.id_manifactur = manufacturer.id";
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
                    rename.Add("name", "Наименование");
                    rename.Add("comments", "Коментарий");
                    _invisibleElements.Add("id");
                    break;
                case "manufacturer":
                    rename.Add("name", "Наименование");
                    rename.Add("comments", "Коментарий");
                    _invisibleElements.Add("id");
                    break;
                case "mark":
                    rename.Add("name", "Наименование");
                    rename.Add("comments", "Коментарий");
                    _invisibleElements.Add("id");
                    break;
                case "material":
                    rename.Add("name", "Наименование");
                    rename.Add("comments", "Коментарий");
                    _invisibleElements.Add("id");
                    _invisibleElements.Add("id_group");
                    _invisibleElements.Add("id_manifactur");
                    break;
                case "units":
                    rename.Add("name", "Наименование");
                    _invisibleElements.Add("id");
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
