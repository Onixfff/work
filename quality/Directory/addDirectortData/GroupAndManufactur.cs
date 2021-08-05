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

namespace quality.Directory.addDirectortData
{
    public partial class GroupAndManufactur : Form
    {
        private string _conn, _dataBase = "material_costumer_manufactur", _table;

        List<string> rename = new List<string>();
        List<string> namesVisibl = new List<string>() { "id" };

        public GroupAndManufactur(string conn, string textBoxName)
        {
            InitializeComponent();
            this._conn = conn;
            if (textBoxName == "_textBoxManufacturer")
            {
                _table = "manufacturer";
                this.Text = "Метериалы";
            }
            else if (textBoxName == "_textBoxMaterial")
            {
                _table = "group_material";
                this.Text = "Производители";
            }
            else
            {
                this.Dispose();
                this.Close();
            }
            Renewal();
        }
        private void AddList()
        { 
            rename.Add("Наименование");
            rename.Add("Комментарий");
        }

        private void RenameAndVisibl(DataSet ds)
        {
            foreach (DataGridViewColumn item in dataGridViewGroupAndManufactur.Columns)
            {
                if (namesVisibl.Contains(item.Name)) item.Visible = false;
            }
            dataGridViewGroupAndManufactur.Columns["name"].HeaderText = rename[0];
            dataGridViewGroupAndManufactur.Columns["comments"].HeaderText = rename[1];
        }

        private void Renewal()
        {
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                try
                {
                    mCon.Open();
                    string sql = ("select id, name, comments from " + _dataBase + "." + _table + "");
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    dataGridViewGroupAndManufactur.DataSource = ds.Tables[0];
                    AddList();
                    RenameAndVisibl(ds);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка");
                }
                finally
                {
                    mCon.Close();
                }
            }
        }

        private void dataGridViewGroupAndManufactur_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
