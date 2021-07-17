using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quality
{
    public partial class Calculate : Form
    {
        private string _conn;
        private int[] _idForms = new int[2];
        public Calculate(string conn)
        {
            _conn = conn;
            InitializeComponent();

            comboBox1.Items.AddRange(AddItemsComboBox());
        }

        private object[] AddItemsComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(_conn))
            {
                string query = "SELECT nParty FROM mmm.aerated_block group by nParty";
                query = "select nParty from aerated_block where (creat_result = 0) group by nParty";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                object[] selecter = new object[0];
                int step = 0;
                while (reader.Read())
                {
                    object[] newSelector = new object[selecter.Length + 1];
                    for(int i = 0; i < selecter.Length; i++)
                    {
                        newSelector[i] = selecter[i];
                    }
                    newSelector[step] = reader.GetValue(0);
                    selecter = newSelector;
                    step++;
                }


                connection.Close();

                return selecter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Trim() != string.Empty) 
            {
                using (MySqlConnection connection = new MySqlConnection(_conn))
                {
                    dataGridView_Calculat.Visible = true;
                    string query = "SELECT drySampleWeight_gram, sampleWetWeight_gram ,BreakingLoad_kH, long_mm, width_mm, height_mm FROM mmm.aerated_block where (nParty = '" + comboBox1.Text + "')";
                    connection.Open();
                    MySqlDataAdapter dD = new MySqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, query);
                    connection.Close();
                    dataGridView_Calculat.DataSource = ds.Tables[0];
                }
            }
        }

        private void textBox_brand_Click(object sender, EventArgs e)
        {
            Brand form = new Brand(_conn);

            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox_brand.Text = form.dataGridView_brand.SelectedRows[0].Cells[1].Value.ToString();
                _idForms[0] = Convert.ToInt32(form.dataGridView_brand.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void textBox_class_Click(object sender, EventArgs e)
        {
            Class form = new Class(_conn);

            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox_class.Text = form.dataGridView_class.SelectedRows[0].Cells[1].Value.ToString();
                _idForms[1] = Convert.ToInt32(form.dataGridView_class.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
