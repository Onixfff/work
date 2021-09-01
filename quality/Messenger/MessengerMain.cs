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
            switch (this.database_toolStripComboBox.Text)
            {
                case "Входящие":
                    _typeMessage = 1;
                    break;
                case "Исходящие":
                    _typeMessage = 2;
                    break;
                case "Внутренние":
                    _typeMessage = 3;
                    break;
                default:
                    MessageBox.Show("Такой базы не обнаружено");
                    break;
            }
            ChangeDataInDataGrid(_typeMessage);
        }

        private void ChangeDataInDataGrid(int _typeMessage)
        {
            DatabaseMessanger db = new DatabaseMessanger(_conn, _table);
            db.ChangeDataInDataGrid(dataGridViewMessanger, _typeMessage);
        }
    }
}
