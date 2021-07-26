
namespace quality.Calculate
{
    partial class DataConfirmation
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
            this.textBox_idParty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_densityActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_strengthActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_humidityActual = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_idParty
            // 
            this.textBox_idParty.Location = new System.Drawing.Point(160, 30);
            this.textBox_idParty.Name = "textBox_idParty";
            this.textBox_idParty.Size = new System.Drawing.Size(100, 20);
            this.textBox_idParty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер партии";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(261, 258);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(120, 53);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Средняя плотность";
            // 
            // textBox_densityActual
            // 
            this.textBox_densityActual.Location = new System.Drawing.Point(160, 72);
            this.textBox_densityActual.Name = "textBox_densityActual";
            this.textBox_densityActual.Size = new System.Drawing.Size(100, 20);
            this.textBox_densityActual.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Средняя сила";
            // 
            // textBox_strengthActual
            // 
            this.textBox_strengthActual.Location = new System.Drawing.Point(160, 116);
            this.textBox_strengthActual.Name = "textBox_strengthActual";
            this.textBox_strengthActual.Size = new System.Drawing.Size(100, 20);
            this.textBox_strengthActual.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Средняя влажность";
            // 
            // textBox_humidityActual
            // 
            this.textBox_humidityActual.Location = new System.Drawing.Point(160, 161);
            this.textBox_humidityActual.Name = "textBox_humidityActual";
            this.textBox_humidityActual.Size = new System.Drawing.Size(100, 20);
            this.textBox_humidityActual.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_idParty);
            this.groupBox1.Controls.Add(this.textBox_humidityActual);
            this.groupBox1.Controls.Add(this.textBox_densityActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_strengthActual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // textBox_brand
            // 
            this.textBox_brand.Location = new System.Drawing.Point(405, 38);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(100, 20);
            this.textBox_brand.TabIndex = 10;
            this.textBox_brand.Click += new System.EventHandler(this.textBox_brand_Click);
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Location = new System.Drawing.Point(343, 41);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(40, 13);
            this.label_brand.TabIndex = 11;
            this.label_brand.Text = "Марка";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(343, 85);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(38, 13);
            this.label_class.TabIndex = 13;
            this.label_class.Text = "Класс";
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(405, 82);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(100, 20);
            this.textBox_class.TabIndex = 12;
            this.textBox_class.Click += new System.EventHandler(this.textBox_class_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(405, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 106);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Коментарий";
            // 
            // DataConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.textBox_brand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSend);
            this.Name = "DataConfirmation";
            this.Text = "DataConfirmation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_idParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_densityActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_strengthActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_humidityActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_brand;
        public System.Windows.Forms.TextBox textBox_class;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}