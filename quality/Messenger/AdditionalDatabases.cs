using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quality.Messenger
{
    public partial class AdditionalDatabases : Form
    {

        private string _conn;
        private readonly Enum _form;
        private string _dataBase = "documents";
        private string _table;
        private string _sql;

        public AdditionalDatabases(string conn, Enum form)
        {
            this._conn = conn;
            _form = form;
            TableName(form);
            InitializeComponent();
            DatabaseMessenger db = new DatabaseMessenger(_conn, _table);
            db.ChangeDataInDataGridView(dataGridViewAdditionalDatabases, _sql);
        }

        private void TableName(Enum formOpen)
        {
            switch (formOpen)
            {
                case KeyForm.Executor:
                    _dataBase = "users";
                    _table = "users";
                    _sql = $"SELECT `id`,`fam` FROM {_dataBase}.`{_table}`;";
                    break;
                case KeyForm.Recipient:
                    _dataBase = "users";
                    _table = "users";
                    _sql = $"SELECT `id`,`fam` FROM {_dataBase}.`{_table}`;";
                    break;
                case KeyForm.Sender:
                    _table = "senders";
                    _sql = $"SELECT `id`, `name` FROM {_dataBase}.{_table};";
                    break;
                case KeyForm.TypeDocuments:
                    _table = "types documents";
                    _sql = $"SELECT * FROM {_dataBase}.`{_table}`;";
                    break;
                case KeyForm.Сarrier:
                    _table = "carriers";
                    _sql = $"SELECT * FROM {_dataBase}.`{_table}`;";
                    break;
            }
        }

        private void dataGridViewAdditionalDatabases_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
