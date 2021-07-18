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
        private string _idParty;
        public Calculate(string conn)
        {
            _conn = conn;
            InitializeComponent();

            comboBox1.Items.AddRange(ItemsComboboxAndIdNParty());
        }

        private object[] ItemsComboboxAndIdNParty()
        {
            using (MySqlConnection connection = new MySqlConnection(_conn))
            {
                object[] selecter = new object[0];
                string query = "select nParty from aerated_block where (creat_result = 0) group by nParty";
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int step = 0;
                    while (reader.Read())
                    {
                        object[] newSelector = new object[selecter.Length + 1];
                        for (int i = 0; i < selecter.Length; i++)
                        {
                            newSelector[i] = selecter[i];
                        }
                        newSelector[step] = reader.GetValue(0);
                        selecter = newSelector;
                        step++;
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return selecter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Trim() != string.Empty) 
            {
                using (MySqlConnection connection = new MySqlConnection(_conn))
                {
                    label_brand.Visible = true;
                    label_class.Visible = true;
                    textBox_brand.Visible = true;
                    textBox_class.Visible = true;
                    dataGridView_Calculat.Visible = true;
                    string query = "SELECT drySampleWeight_gram, sampleWetWeight_gram ,BreakingLoad_kH, long_mm, width_mm, height_mm, idDensity, id FROM mmm.aerated_block where (nParty = '" + comboBox1.Text + "')";
                    connection.Open();
                    MySqlDataAdapter dD = new MySqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, query);
                    connection.Close();
                    dataGridView_Calculat.DataSource = ds.Tables[0];
                    VisiblFalse();
                    Rename();
                }
            }
        }

        private void Rename()
        {
            List<string> nameEnglish = new List<string>() { "drySampleWeight_gram", "sampleWetWeight_gram", "BreakingLoad_kH", "long_mm", "width_mm", "height_mm" };
            List<string> rename = new List<string>() { "Масса образца сухого, г", "Масса образца влажного, г", "Разрушающая нагрузка ка, кН", "Длинна, мм", "Ширина, мм", "Высота, мм"};
            for(int i = 0; i < rename.Count; i++)
            {
                for(int j = 0; j < dataGridView_Calculat.Columns.Count; j++)
                {
                    if(dataGridView_Calculat.Columns[j].HeaderText == nameEnglish[i])
                    {
                        dataGridView_Calculat.Columns[j].HeaderText = rename[i];
                    }
                }
            }
        }

        private void VisiblFalse()
        {
            List<string> visibleFalse = new List<string>() { "idDensity", "id" };
            for (int i = 0; i < visibleFalse.Count; i++)
            {
                for (int j = 0; j < dataGridView_Calculat.Columns.Count; j++)
                {
                    if (dataGridView_Calculat.Columns[j].HeaderText == visibleFalse[i])
                    {
                        dataGridView_Calculat.Columns[j].Visible = false;
                    }
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

        private void Submit_Click(object sender, EventArgs e)
        {
            bool check = false; // Проверка ошибок и заполнений
            if (comboBox1.Text.Trim() != string.Empty)
            {
                if (textBox_brand.Text.Trim() != string.Empty)
                {
                    if (textBox_class.Text.Trim() != string.Empty)
                    {
                        List<float> with = new List<float>(); // ширина
                        List<float> height = new List<float>(); // высота
                        List<float> long1 = new List<float>(); // длина
                        List<float> breakingLoad_kH = new List<float>(); // разрушающая нагрузка
                        List<int> drySampleWeight_gram = new List<int>(); // Сухой
                        List<int> sampleWetWeight_gram = new List<int>(); // Влажный
                        List<int> id_density = new List<int>();

                        string strengthActual = "";
                        string densityActual = "";
                        string humidityActual = "";
                        _idParty = null;
                        try
                        {
                            int coin = dataGridView_Calculat.SelectedRows.Count;
                            for (int i = 0; i < coin; i++)
                            {
                                with.Add(float.Parse(dataGridView_Calculat.SelectedRows[i].Cells[4].Value.ToString()));
                                height.Add(float.Parse(dataGridView_Calculat.SelectedRows[i].Cells[5].Value.ToString()));
                                long1.Add(float.Parse(dataGridView_Calculat.SelectedRows[i].Cells[3].Value.ToString()));
                                breakingLoad_kH.Add(float.Parse(dataGridView_Calculat.SelectedRows[i].Cells[2].Value.ToString()));
                                drySampleWeight_gram.Add(Convert.ToInt32(dataGridView_Calculat.SelectedRows[i].Cells[0].Value));
                                sampleWetWeight_gram.Add(Convert.ToInt32(dataGridView_Calculat.SelectedRows[i].Cells[1].Value));
                                id_density.Add(Convert.ToInt32(dataGridView_Calculat.SelectedRows[i].Cells[6].Value));
                                _idParty += $"{dataGridView_Calculat.SelectedRows[i].Cells[7].Value} ";
                            }

                            Calculater calculater = new Calculater();
                            strengthActual = calculater.StrangthActual(breakingLoad_kH, long1, with);
                            densityActual = calculater.DensityActual(drySampleWeight_gram, long1, with, height);
                            humidityActual = calculater.HumidityActual(drySampleWeight_gram, sampleWetWeight_gram);

                            int checkId = 0;
                            for (int i = 0; i < id_density.Count(); i++)
                            {
                                checkId = id_density[0];
                                if(checkId == id_density[i])
                                {
                                    checkId = id_density[i];
                                    check = true;
                                }
                                else
                                {
                                    MessageBox.Show($"{Convert.ToString(checkId)} != {Convert.ToString(id_density[i])}\nОшибка в idDensiti");
                                    check = false;
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка расчёта" + ex);
                        }
                        if(check != false)
                        {
                            try
                            {
                                using (MySqlConnection mCon = new MySqlConnection(_conn))
                                {
                                    string queryAerated_blockUpdate = $"update aerated_block set creat_result = 1 where (nParty = '{comboBox1.Text}')";
                                    string queryResult_blockInsert = $"INSERT INTO `mmm`.`result_block` (`id_party`, `density_actual`, `id_density`, `strength_actual`, `id_class`, `id_mark`, `humidity_actual`) VALUES ('{_idParty}', '{densityActual}', '{id_density[0]}', '{strengthActual}', '{_idForms[1]}', '{_idForms[0]}', '{humidityActual}');";
                                    try
                                    {
                                        mCon.Open();
                                        using(MySqlCommand mySqlCommand = mCon.CreateCommand())
                                        {
                                            mySqlCommand.Connection = mCon;
                                            mySqlCommand.CommandText = queryResult_blockInsert;
                                            mySqlCommand.ExecuteNonQuery();
                                            mySqlCommand.CommandText = queryAerated_blockUpdate;
                                            mySqlCommand.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Данные доставлены");
                                    }
                                    catch(Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    finally
                                    {
                                        mCon.Close();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        check = true;
                    }
                }
            }
            if(check == false)
            {
                MessageBox.Show("Заполните все поля");
            }
            this.Dispose();
        }
    }
}
