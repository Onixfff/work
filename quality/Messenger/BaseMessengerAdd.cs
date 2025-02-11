using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality.Messenger
{
    public partial class BaseMessengerAdd : Form
    {
        private readonly Enum sqlFunction;
        private IReadOnlyDictionary<string, string> dbDictionary;
        private readonly int _id;
        private readonly int _typeMessage;
        private int _controlMark;
        private readonly string _conn;
        private readonly string _table;
        private string[] idForms = new string[5];//0 - Carrier; 1 - TypeDocuments; 2 - Sender; 3 - Recipient; 4 - Executor;
        private List<Image> _images = new List<Image>();
        public BaseMessengerAdd(int typeMessage, string nameForm, string conn, string table)
        {
            sqlFunction = SqlFunction.Insert;
            _table = table;
            _conn = conn;
            _typeMessage = typeMessage;
            InitializeComponent();
            this.Text = nameForm;
        }

        public BaseMessengerAdd(int typeMessage, string nameForm, string conn, string table, string id)
        {
            sqlFunction = SqlFunction.Update;
            _table = table;
            _conn = conn;
            _typeMessage = typeMessage;
            InitializeComponent();
            this.Text = nameForm;

            DatabaseMessenger db = new DatabaseMessenger(_conn, _table);
            dbDictionary = db.PostDataUpdate(id, _typeMessage);
            ChangeTextInForm();
        }

        private void ChangeTextInForm()
        {
            for (int index = 0; index < Controls.Count; index++)
            {
                for (int i = 0; i < dbDictionary.Count; i++)
                {
                    if (Controls[index].Tag != null)
                    {
                        var item = dbDictionary.ElementAt(i);
                        if (Controls[index].Tag.ToString() == item.Key)
                        {
                            if(Controls[index].Tag.ToString() == "id carrier")
                            {
                                idForms[0] = item.Value;
                                item = dbDictionary.ElementAt(++i);
                                Controls[index].Text = item.Value;
                            }
                            else if (Controls[index].Tag.ToString() == "id type documents")
                            {
                                idForms[1] = item.Value;
                                item = dbDictionary.ElementAt(++i);
                                Controls[index].Text = item.Value;
                            }
                            else if (Controls[index].Tag.ToString() == "id sender")
                            {
                                idForms[2] = item.Value;
                                item = dbDictionary.ElementAt(++i);
                                Controls[index].Text = item.Value;
                            }
                            else if (Controls[index].Tag.ToString() == "id recipient")
                            {
                                idForms[3] = item.Value;
                                item = dbDictionary.ElementAt(++i);
                                Controls[index].Text = item.Value;
                            }
                            else if (Controls[index].Tag.ToString() == "id executor")
                            {
                                idForms[4] = item.Value;
                                item = dbDictionary.ElementAt(++i);
                                Controls[index].Text = item.Value;
                            }
                            else 
                            {
                                if (Controls[index] is CheckBox)
                                {
                                    if (item.Value == "True")
                                        checkBox1.Checked = true;
                                    else if (item.Value == "False")
                                        checkBox1.Checked = false;
                                }
                                else
                                {
                                    Controls[index].Text = item.Value;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            DateTime dt3 = dateTimePicker2.Value;
            DateTime dt4 = dateTimePicker2.Value;
            DateTime dt5 = dateTimePicker5.Value;
            DateTime dt6 = dateTimePicker6.Value;

            Dictionary<string, string> dictionarySubmit = new Dictionary<string, string>()
            {
                {textBox1.Tag.ToString(), textBox1.Text},
                {dateTimePicker1.Tag.ToString(), dt1.ToString("yy-MM-dd")},
                {textBoxCarrier.Tag.ToString(), idForms[0]},
                {textBoxTypeDocuments.Tag.ToString(), idForms[1]},
                {textBoxSender.Tag.ToString(), idForms[2]},
                {textBox6.Tag.ToString(), textBox6.Text},
                {dateTimePicker4.Tag.ToString(), dt4.ToString("yy-MM-dd")},
                {textBoxRecipient.Tag.ToString(), idForms[3]},
                {textBox9.Tag.ToString(), textBox9.Text},
                {richTextBox1.Tag.ToString(), richTextBox1.Text},
                {textBoxExecutor.Tag.ToString(), idForms[4]},
                {dateTimePicker2.Tag.ToString(), dt2.ToString("yy-MM-dd")},
                {textBox12.Tag.ToString(), textBox12.Text},
                {dateTimePicker3.Tag.ToString(), dt3.ToString("yy-MM-dd")},
                {dateTimePicker5.Tag.ToString(), dt5.ToString("yy-MM-dd")},
                {checkBox1.Tag.ToString(), _controlMark.ToString()},
                {dateTimePicker6.Tag.ToString(), dt6.ToString("yy-MM-dd")},
                {textBox7.Tag.ToString(), textBox7.Text},
                {textBox11.Tag.ToString(), textBox11.Text},
                {textBox13.Tag.ToString(), textBox13.Text},
                {"type message", _typeMessage.ToString()}
            };

            DatabaseMessenger db = new DatabaseMessenger(_conn, _table);
            if (sqlFunction.Equals(SqlFunction.Insert))
                db.InsertData(dictionarySubmit);
            else
                db.UpdateData(dictionarySubmit);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _controlMark = checkBox1.Checked == true ? 1 : 0;
        }

        private void textBoxCarrier_Click(object sender, EventArgs e)
        {
            AdditionalDatabases form = new AdditionalDatabases(_conn, KeyForm.Сarrier);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBoxCarrier.Text = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[1].Value.ToString();
                idForms[0] = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void textBoxTypeDocuments_Click(object sender, EventArgs e)
        {
            AdditionalDatabases form = new AdditionalDatabases(_conn, KeyForm.TypeDocuments);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBoxTypeDocuments.Text = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[1].Value.ToString();
                idForms[1] = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void textBoxSender_Click(object sender, EventArgs e)
        {
            AdditionalDatabases form = new AdditionalDatabases(_conn, KeyForm.Sender);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBoxSender.Text = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[1].Value.ToString();
                idForms[2] = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void textBoxRecipient_Click(object sender, EventArgs e)
        {
            AdditionalDatabases form = new AdditionalDatabases(_conn, KeyForm.Recipient);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBoxRecipient.Text = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[1].Value.ToString();
                idForms[3] = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void textBoxExecutor_Click(object sender, EventArgs e)
        {
            AdditionalDatabases form = new AdditionalDatabases(_conn, KeyForm.Executor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                textBoxExecutor.Text = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[1].Value.ToString();
                idForms[4] = form.dataGridViewAdditionalDatabases.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void submitPhoto_Click(object sender, EventArgs e)
        {
            PhotosMessenger form = new PhotosMessenger(_images);
            if(form.ShowDialog() == DialogResult.OK)
            {
                _images = form._images;
            }
        }
    }
}
