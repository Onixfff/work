﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace quality
{
    public partial class ResultBlocks : Form
    {
        private string _conn, _table = "result_block", _dataBase = "mmm";
        List<string> rename = new List<string>();
        List<string> namesVisibl = new List<string>() { "id" };
        public ResultBlocks(string conn)
        {
            this._conn = conn;
            InitializeComponent();
            Renewal();
        }

        private void AddList()
        {
            rename.Add("номер партии");
            rename.Add("фактическая плотность");
            rename.Add("номер плотности");
            rename.Add("сила действительная");
            rename.Add("номер класса");
            rename.Add("номер марки");
            rename.Add("фактическая влажность");
            rename.Add("Комментарий");
        }

        private void RenameAndVisibl(DataSet ds)
        {
            foreach (DataGridViewColumn item in dataGridView_ResultBlock.Columns)
            {
                if (namesVisibl.Contains(item.Name)) item.Visible = false;
            }
            dataGridView_ResultBlock.Columns["id_party"].HeaderText = rename[0];
            dataGridView_ResultBlock.Columns["density_actual"].HeaderText = rename[1];
            dataGridView_ResultBlock.Columns["id_density"].HeaderText = rename[2];
            dataGridView_ResultBlock.Columns["strength_actual"].HeaderText = rename[3];
            dataGridView_ResultBlock.Columns["id_class"].HeaderText = rename[4];
            dataGridView_ResultBlock.Columns["id_mark"].HeaderText = rename[5];
            dataGridView_ResultBlock.Columns["humidity_actual"].HeaderText = rename[6];
            dataGridView_ResultBlock.Columns["comments"].HeaderText = rename[7];
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView_ResultBlock_DoubleClick(object sender, EventArgs e)
        {
            string id = dataGridView_ResultBlock.SelectedRows[0].Cells["id_party"].Value.ToString();
            ResultBlockBonus form = new ResultBlockBonus(_conn, id);
            form.ShowDialog();
        }

        private void Renewal()
        {
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                try
                {
                    mCon.Open();
                    string sql = ("select * from " + _dataBase + ".`" + _table + "`");
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    dataGridView_ResultBlock.DataSource = ds.Tables[0];

                    AddList();
                    RenameAndVisibl(ds);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mCon.Close();
                }
            }
        }

        private void dataGridView_density_DoubleClick_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
