
namespace quality
{
    partial class Calculate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.dataGridView_Calculat = new System.Windows.Forms.DataGridView();
            this.textBox_class = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Calculat)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_brand
            // 
            this.textBox_brand.Location = new System.Drawing.Point(443, 29);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(138, 20);
            this.textBox_brand.TabIndex = 4;
            this.textBox_brand.Visible = false;
            this.textBox_brand.Click += new System.EventHandler(this.textBox_brand_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(334, 461);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(129, 50);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Подсчитать данные";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Location = new System.Drawing.Point(492, 13);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(40, 13);
            this.label_brand.TabIndex = 7;
            this.label_brand.Text = "Марка";
            this.label_brand.Visible = false;
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(686, 13);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(38, 13);
            this.label_class.TabIndex = 8;
            this.label_class.Text = "Класс";
            this.label_class.Visible = false;
            // 
            // dataGridView_Calculat
            // 
            this.dataGridView_Calculat.AllowUserToAddRows = false;
            this.dataGridView_Calculat.AllowUserToDeleteRows = false;
            this.dataGridView_Calculat.AllowUserToOrderColumns = true;
            this.dataGridView_Calculat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Calculat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Calculat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Calculat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Calculat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Calculat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Calculat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Calculat.Location = new System.Drawing.Point(12, 85);
            this.dataGridView_Calculat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Calculat.Name = "dataGridView_Calculat";
            this.dataGridView_Calculat.RowHeadersVisible = false;
            this.dataGridView_Calculat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Calculat.ShowEditingIcon = false;
            this.dataGridView_Calculat.Size = new System.Drawing.Size(776, 353);
            this.dataGridView_Calculat.TabIndex = 15;
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(638, 29);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(138, 20);
            this.textBox_class.TabIndex = 16;
            this.textBox_class.Visible = false;
            this.textBox_class.Click += new System.EventHandler(this.textBox_class_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 523);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.dataGridView_Calculat);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox_brand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберка элемента расчёта";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Calculat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.TextBox @class;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_class;
        public System.Windows.Forms.DataGridView dataGridView_Calculat;
        private System.Windows.Forms.TextBox textBox_class;
    }
}