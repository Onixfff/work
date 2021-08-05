using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality.Calculate
{
    public partial class DataConfirmation : Form
    {
        private object[] _data;
        private string _conn;
        public int[] idForms = new int[3];
        public DataConfirmation(object[] data, string conn)
        {
            _conn = conn;
            _data = data;
            InitializeComponent();
            textBox_idParty.Text = (string)data[0];
            textBox_densityActual.Text = (string)data[1];
            textBox_strengthActual.Text = (string)data[2];
            textBox_humidityActual.Text = (string)data[3];
        }

        private void textBox_brand_Click(object sender, EventArgs e)
        {
            Brand form = new Brand(_conn);

            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox_brand.Text = form.dataGridView_brand.SelectedRows[0].Cells[1].Value.ToString();
                idForms[0] = Convert.ToInt32(form.dataGridView_brand.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void textBox_class_Click(object sender, EventArgs e)
        {
            Class form = new Class(_conn);

            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox_class.Text = form.dataGridView_class.SelectedRows[0].Cells[1].Value.ToString();
                idForms[1] = Convert.ToInt32(form.dataGridView_class.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBox_brand.Text.Trim() != string.Empty)
            {
                if(textBox_class.Text.Trim() != string.Empty)
                {
                    if(richTextBox1.Text.Trim().Length <= 120)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ShowNotificationClient("Кол-во символов в коментарии не должно привышать 120 у вас "+richTextBox1.Text.Length);
                    }
                }
                else
                {
                    ShowNotificationClient();
                }
            }
            else
            {
                ShowNotificationClient();
            }
        }
        private void ShowNotificationClient(string text = "Выбирите класс и марку для отправки")
        {
            MessageBox.Show(text);
        }
    }
}
