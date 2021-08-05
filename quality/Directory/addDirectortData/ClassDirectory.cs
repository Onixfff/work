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
    public partial class ClassDirectory : Form
    {
        private int id;
        private Label _labelShifr; //hack Изменить название.
        private Label _labelMaterial;
        private Label _labelManufacturer;

        private Dictionary<string, string> _changes;

        private TextBox _textBoxShifr;
        private TextBox _textBoxMaterial;
        private TextBox _textBoxManufacturer;

        private string _table;
        private string _query;
        private string _conn;
        private int[] _idForms = new int[2]; // _idForms[0] - Group, _idForms[1] - Manufactur
        public ClassDirectory(string table, string conn, Dictionary<string, string> changes = null)
        {
            _conn = conn;
            _table = table;
            InitializeComponent();
            ChangesTheShapeToFitTheTable();
            if (changes != null)
            {
                _changes = changes;
                InputDataInObject(changes);
            }
        }

        private void InputDataInObject(Dictionary<string,string> changes)
        {
            for (int i = 0; i < changes.Count; i++)
            {
                for (int j = 0; j < Controls.Count; j++)
                {
                    if (changes.ElementAt(i).Key == Controls[j].Name)
                        Controls[j].Text = changes.ElementAt(i).Value;
                    else if (changes.ElementAt(i).Key == "id_group")
                        _idForms[0] = Convert.ToInt32(changes.ElementAt(i).Value);
                    else if (changes.ElementAt(i).Key == "id_manifactur")
                        _idForms[1] = Convert.ToInt32(changes.ElementAt(i).Value);
                    else if (changes.ElementAt(i).Key == "id")
                        id = Convert.ToInt32(changes.ElementAt(i).Value);
                }
            }
        }

        private void ChangesTheShapeToFitTheTable()
        {
            switch (_table)
            {
                case "class":

                    break;
                case "group_material":

                    break;
                case "manufacturer":

                    break;
                case "mark":
                    this.Text = "Марка";
                    break;
                case "material":
                    // Изменение вида формы для Материала
                    this.Text = "Материал";
                    this.Size = new Size(484,276);
                    this.MaximumSize = new Size(484, 276);
                    this.MinimumSize = new Size(484, 276);
                    //
                    // Инициализация labelShif
                    //
                    _labelShifr = new Label();
                    _labelShifr.AutoSize = true;
                    _labelShifr.Text = "Шифр";
                    _labelShifr.Name = "labelShift";
                    _labelShifr.Size = new Size(_labelShifr.PreferredWidth, _labelShifr.PreferredHeight);
                    _labelShifr.Location = new Point(19, 72);
                    //
                    // Инициализация lavelMetarial
                    //
                    _labelMaterial = new Label();
                    _labelMaterial.AutoSize = true;
                    _labelMaterial.Text = "Материал";
                    _labelMaterial.Size = new Size(_labelMaterial.PreferredWidth, _labelMaterial.PreferredHeight);
                    _labelMaterial.Location = new Point(19, 124);
                    //
                    // Инициализация labelMaufacturer
                    //
                    _labelManufacturer = new Label();
                    _labelManufacturer.AutoSize = true;
                    _labelManufacturer.Text = "Производитель";
                    _labelManufacturer.Size = new Size(_labelManufacturer.PreferredWidth,_labelManufacturer.PreferredHeight);
                    _labelManufacturer.Location = new Point(224, 28);
                    //
                    // Изменяет местоположение labelComment
                    //
                    labelComment.Location = new Point(224, 95);
                    //
                    // Изменяет местоположение labelName
                    //
                    labelName.Location = new Point(19, 28);
                    //
                    // Изменяет местоположение textBoxName
                    //
                    textBoxName.Location = new Point(108, 25);
                    textBoxName.Size = new Size(100, 20);
                    textBoxName.TabIndex = 1;
                    //
                    // Изменяет местоположение richTextBoxComment
                    //
                    richTextBoxComment.Location = new Point(316, 81);
                    richTextBoxComment.Size = new Size(134, 71);
                    richTextBoxComment.TabIndex = 5;
                    //
                    // Инициализирует textBoxShifr
                    //
                    _textBoxShifr = new TextBox();
                    _textBoxShifr.Name = "_textBoxShifr";
                    _textBoxShifr.Location = new Point(108, 72);
                    _textBoxShifr.Size = new Size(100, 20);
                    _textBoxShifr.TabIndex = 2;
                    //
                    // Инициализирует _textBoxMaterial
                    //
                    _textBoxMaterial = new TextBox();
                    _textBoxMaterial.Location = new Point(108, 121);
                    _textBoxMaterial.Size = new Size(100, 20);
                    _textBoxMaterial.Name = "_textBoxMaterial";
                    _textBoxMaterial.TabIndex = 3;
                    _textBoxMaterial.Click += new System.EventHandler(TextBoxMaterial_Click);
                    //
                    // Инициализирует _textBoxManufacturer
                    //
                    _textBoxManufacturer = new TextBox();
                    _textBoxManufacturer.Location = new Point(316, 25);
                    _textBoxManufacturer.Size = new Size(134, 20);
                    _textBoxManufacturer.Name = "_textBoxManufacturer";
                    _textBoxManufacturer.TabIndex = 4;
                    _textBoxManufacturer.Click += new System.EventHandler(TextBoxManufacturer_Click);
                    //
                    // Добавление в колекцию Controls для отображения
                    //
                    this.Controls.Add(_textBoxShifr);
                    this.Controls.Add(_labelShifr);
                    this.Controls.Add(_labelMaterial);
                    this.Controls.Add(_labelManufacturer);
                    this.Controls.Add(_textBoxShifr);
                    this.Controls.Add(_textBoxMaterial);
                    this.Controls.Add(_textBoxManufacturer);
                    //
                    // Изменение местоположения кнопки
                    //
                    buttonSubmit.Location = new Point(190, 174);
                    buttonSubmit.TabIndex = 6;
                    break;
                case "units":
                    // Изменение вида формы для единиц измерения
                    this.Size = new Size(253, 178);
                    this.MinimumSize = new Size(253, 178);
                    this.MaximumSize = new Size(253, 178);
                    labelName.Location = new Point(12, 27);
                    textBoxName.Location = new Point(108, 24);
                    buttonSubmit.Location = new Point(71, 75);
                    labelComment.Dispose();
                    richTextBoxComment.Dispose();
                    break;
                default:
                    break;
            }
        }

        private bool CheckCorrectInput()
        {
            bool check = true;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == textBoxName.GetType())
                {
                    if (Controls[i].Text.Trim() != string.Empty)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                else if (Controls[i].GetType() == richTextBoxComment.GetType())
                {
                    if(Controls[i].Text.Length < 120)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }

        private void CreateQuery()
        {
            bool check = CheckCorrectInput();
            if (check == true)
            {
                DatabaseDirectoryAdd db = new DatabaseDirectoryAdd(_table, _conn);
                if (_changes == null)
                {
                    _query = $"(`name`, `comments`) VALUES ('{textBoxName.Text}', '{richTextBoxComment.Text}');";
                    switch (_table)
                    {
                        case "class":

                            break;
                        case "group_material":

                            break;
                        case "manufacturer":

                            break;
                        case "mark":

                            break;
                        case "material":
                            _query = $"(`name`, `shifr`, `id_group`, `id_manifactur`, `comments`) VALUES ('{textBoxName.Text}', '{_textBoxShifr.Text}', '{_idForms[0]}', '{_idForms[1]}', '{richTextBoxComment.Text}');";
                            break;
                        case "units":
                            _query = $"(`name`) VALUES ('{textBoxName.Text}');";
                            break;
                        default:
                            Console.WriteLine("Для такой таблицы нету sql кода");
                            break;
                    }
                    db.InputData(_query);
                }
                else
                {
                    _query = $"`name` = '{textBoxName.Text}', `comments` = '{richTextBoxComment.Text}' where (`id` = '{id}')";
                    switch (_table)
                    {
                        case "class":

                            break;
                        case "group_material":

                            break;
                        case "manufacturer":

                            break;
                        case "mark":

                            break;
                        case "material":
                            _query = $"`name` = '{textBoxName.Text}', `shifr` = '{_textBoxShifr.Text}', `id_group` = '{_idForms[0]}', `id_manifactur` = '{_idForms[1]}', `comments` = '{richTextBoxComment.Text}' WHERE (`id` = '{id}');";
                            break;
                        case "units":
                            _query = $"`name` = '{textBoxName.Text}' where (`id` = '{id}')";
                            break;
                        default:
                            Console.WriteLine("Для такой таблицы нету sql кода");
                            break;
                    }
                    db.UpdateData(_query);
                }
            }
            else
            {
                MessageBox.Show("Неправельно заполнены данные");
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            CreateQuery();
            this.Dispose();
            this.Close();
        }

        private void TextBoxMaterial_Click(object sender, EventArgs e)
        {
            using (GroupAndManufactur groupOfMoldsAndManufacturers = new GroupAndManufactur(_conn, _textBoxMaterial.Name))
            {
                if (groupOfMoldsAndManufacturers.ShowDialog() == DialogResult.OK)
                {
                    _textBoxMaterial.Text = groupOfMoldsAndManufacturers.dataGridViewGroupAndManufactur.SelectedRows[0].Cells[1].Value.ToString();
                    _idForms[0] = Convert.ToInt32(groupOfMoldsAndManufacturers.dataGridViewGroupAndManufactur.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void TextBoxManufacturer_Click(object sender, EventArgs e)
        {
            using (GroupAndManufactur groupOfMoldsAndManufacturers = new GroupAndManufactur(_conn, _textBoxManufacturer.Name))
            {
                if (groupOfMoldsAndManufacturers.ShowDialog() == DialogResult.OK)
                {
                    _textBoxManufacturer.Text = groupOfMoldsAndManufacturers.dataGridViewGroupAndManufactur.SelectedRows[0].Cells[1].Value.ToString();
                    _idForms[1] = Convert.ToInt32(groupOfMoldsAndManufacturers.dataGridViewGroupAndManufactur.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }
    }
}
