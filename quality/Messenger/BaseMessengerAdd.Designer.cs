
namespace quality.Messenger
{
    partial class BaseMessengerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.submit = new System.Windows.Forms.Button();
            this.submitPhoto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCarrier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTypeDocuments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExecutor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.viewPhotos = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(444, 633);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(96, 59);
            this.submit.TabIndex = 0;
            this.submit.Text = "Сохранить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // submitPhoto
            // 
            this.submitPhoto.Location = new System.Drawing.Point(869, 46);
            this.submitPhoto.Name = "submitPhoto";
            this.submitPhoto.Size = new System.Drawing.Size(96, 66);
            this.submitPhoto.TabIndex = 1;
            this.submitPhoto.Text = "Добавить фото";
            this.submitPhoto.UseVisualStyleBackColor = true;
            this.submitPhoto.Click += new System.EventHandler(this.submitPhoto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер Входящего";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата Входящего";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Носитель";
            // 
            // textBoxCarrier
            // 
            this.textBoxCarrier.Location = new System.Drawing.Point(179, 83);
            this.textBoxCarrier.Name = "textBoxCarrier";
            this.textBoxCarrier.Size = new System.Drawing.Size(231, 20);
            this.textBoxCarrier.TabIndex = 6;
            this.textBoxCarrier.Tag = "id carrier";
            this.textBoxCarrier.Click += new System.EventHandler(this.textBoxCarrier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип документа";
            // 
            // textBoxTypeDocuments
            // 
            this.textBoxTypeDocuments.Location = new System.Drawing.Point(179, 118);
            this.textBoxTypeDocuments.Name = "textBoxTypeDocuments";
            this.textBoxTypeDocuments.Size = new System.Drawing.Size(231, 20);
            this.textBoxTypeDocuments.TabIndex = 8;
            this.textBoxTypeDocuments.Tag = "id type documents";
            this.textBoxTypeDocuments.Click += new System.EventHandler(this.textBoxTypeDocuments_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отправитель";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(179, 155);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(655, 20);
            this.textBoxSender.TabIndex = 10;
            this.textBoxSender.Tag = "id sender";
            this.textBoxSender.Click += new System.EventHandler(this.textBoxSender_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "№ Исходящего";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(179, 194);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.Tag = "sender Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата Исходящего";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Получатель";
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Location = new System.Drawing.Point(179, 233);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(655, 20);
            this.textBoxRecipient.TabIndex = 16;
            this.textBoxRecipient.Tag = "id recipient";
            this.textBoxRecipient.Click += new System.EventHandler(this.textBoxRecipient_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Наименование документа";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(179, 273);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(655, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.Tag = "name documents";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Краткое содержание\r\n документа";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(655, 96);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Tag = "comment";
            this.richTextBox1.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Исполнитель";
            // 
            // textBoxExecutor
            // 
            this.textBoxExecutor.Location = new System.Drawing.Point(179, 431);
            this.textBoxExecutor.Name = "textBoxExecutor";
            this.textBoxExecutor.Size = new System.Drawing.Size(231, 20);
            this.textBoxExecutor.TabIndex = 23;
            this.textBoxExecutor.Tag = "id executor";
            this.textBoxExecutor.Click += new System.EventHandler(this.textBoxExecutor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Дата получения документа исполнителем";
            // 
            // viewPhotos
            // 
            this.viewPhotos.Location = new System.Drawing.Point(971, 46);
            this.viewPhotos.Name = "viewPhotos";
            this.viewPhotos.Size = new System.Drawing.Size(101, 66);
            this.viewPhotos.TabIndex = 27;
            this.viewPhotos.Text = "Фото входящего";
            this.viewPhotos.UseVisualStyleBackColor = true;
            this.viewPhotos.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Наш Исх. №";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(179, 469);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 28;
            this.textBox12.Tag = "recipient number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Дата нашего Исходящего";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Tag = "date input";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(685, 431);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.Tag = "executor date of receiving";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(477, 469);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker3.TabIndex = 36;
            this.dateTimePicker3.Tag = "outgoing date";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(444, 194);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker4.TabIndex = 37;
            this.dateTimePicker4.Tag = "sender date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Дата контроля";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(360, 511);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Tag = "control mark";
            this.checkBox1.Text = "На контроль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(179, 509);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker5.TabIndex = 41;
            this.dateTimePicker5.Tag = "control date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 550);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Дата исполнения";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 550);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Отметка об исполнении";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(486, 547);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 44;
            this.textBox7.Tag = "execution mark";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 585);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Местонахождение";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(179, 582);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(652, 20);
            this.textBox11.TabIndex = 46;
            this.textBox11.Tag = "location";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 621);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Кол-во экземпляров";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(179, 618);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 48;
            this.textBox13.Tag = "number copies";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(179, 547);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker6.TabIndex = 50;
            this.dateTimePicker6.Tag = "execution date";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images | *.bmp;  *.png;  *jpg; *.JPEG";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BaseMessengerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 704);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.viewPhotos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxExecutor);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRecipient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTypeDocuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCarrier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitPhoto);
            this.Controls.Add(this.submit);
            this.Name = "BaseMessengerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseMessengerAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button submitPhoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCarrier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTypeDocuments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxExecutor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button viewPhotos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}