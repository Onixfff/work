
namespace quality
{
    partial class Calculat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxNParty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.dataGridView_Calculat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Calculat)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxNParty
            // 
            this.comboBoxNParty.FormattingEnabled = true;
            this.comboBoxNParty.Location = new System.Drawing.Point(12, 29);
            this.comboBoxNParty.Name = "comboBoxNParty";
            this.comboBoxNParty.Size = new System.Drawing.Size(155, 21);
            this.comboBoxNParty.TabIndex = 0;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Calculat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Calculat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Calculat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Calculat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Calculat.Location = new System.Drawing.Point(12, 85);
            this.dataGridView_Calculat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Calculat.Name = "dataGridView_Calculat";
            this.dataGridView_Calculat.RowHeadersVisible = false;
            this.dataGridView_Calculat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Calculat.ShowEditingIcon = false;
            this.dataGridView_Calculat.Size = new System.Drawing.Size(776, 353);
            this.dataGridView_Calculat.TabIndex = 15;
            // 
            // Calculat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 523);
            this.Controls.Add(this.dataGridView_Calculat);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNParty);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 562);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 562);
            this.Name = "Calculat";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберка элемента расчёта";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Calculat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxNParty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox @class;
        private System.Windows.Forms.Button Submit;
        public System.Windows.Forms.DataGridView dataGridView_Calculat;
    }
}