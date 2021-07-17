using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality
{
    public partial class Class : Form
    {
        private string _conn, _dataBase = "material_costumer_manufactur", _table = "class";

        List<string> rename = new List<string>();
        List<string> namesVisibl = new List<string>() { "id" };

        public Class(string conn)
        {
            this._conn = conn;
            InitializeComponent();
            Renewal();
        }

        private void AddList()
        {
            rename.Add("Наименование");
            rename.Add("Комментарий");
        }

        private void RenameAndVisibl(DataSet ds)
        {
            foreach (DataGridViewColumn item in dataGridView_class.Columns)
            {
                if (namesVisibl.Contains(item.Name)) item.Visible = false;
            }
            dataGridView_class.Columns["name"].HeaderText = rename[0];
            dataGridView_class.Columns["comments"].HeaderText = rename[1];
        }

        private void Renewal()
        {
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                mCon.Open();
                string sql = ("select id, name, comments from " + _dataBase + "." + _table + "");
                MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                DataSet ds = new DataSet();
                ds.Reset();
                dD.Fill(ds, sql);
                dataGridView_class.DataSource = ds.Tables[0];

                AddList();
                RenameAndVisibl(ds);

                mCon.Close();
            }
        }

        private void dataGridView_class_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
