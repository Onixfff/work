using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality.Messenger
{
    public partial class MessengerMain : Form
    {
        private string _conn;
        private string _table;

        private int _typeMessage;

        public MessengerMain(string conn, string table)
        {
            _conn = conn;
            _table = table;
            InitializeComponent();
            this.AccessibleDefaultActionDescription = _table;
        }

        private void MessengerMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if(CheckSelectComboBox("Такой базы не обнаружено") != 0)
                ChangeDataInDataGrid(_typeMessage);
        }

        private void ChangeDataInDataGrid(int _typeMessage)
        {
            DatabaseMessenger db = new DatabaseMessenger(_conn, _table);
            db.ChangeDataInDataGridView(dataGridViewMessanger, _typeMessage);
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            if (CheckSelectComboBox("Выбирите базу для добавления данных") != 0)
            {
                BaseMessengerAdd form = new BaseMessengerAdd(_typeMessage, database_toolStripComboBox.Text, _conn, _table);
                form.ShowDialog();
            }
        }

        private int CheckSelectComboBox(string error)
        {
            switch (this.database_toolStripComboBox.Text)
            {
                case "Входящие":
                    return _typeMessage = 1;
                case "Исходящие":
                    return _typeMessage = 2;
                case "Внутренние":
                    return _typeMessage = 3;
                default:
                    MessageBox.Show(error);
                    return _typeMessage = 0;
            }
        }

        private void toolStripUpdate_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewMessanger.SelectedRows.Count;
            string id = dataGridViewMessanger.SelectedRows[0].Cells["№ Входящего"].Value.ToString();

            BaseMessengerAdd form = new BaseMessengerAdd(_typeMessage, database_toolStripComboBox.Text, _conn, _table, id);
            form.ShowDialog();
        }
    }
}
