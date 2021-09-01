
namespace quality.Messenger
{
    partial class MessengerMain
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
            this.dataGridViewMessanger = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.database_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessanger)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMessanger
            // 
            this.dataGridViewMessanger.AllowUserToAddRows = false;
            this.dataGridViewMessanger.AllowUserToDeleteRows = false;
            this.dataGridViewMessanger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMessanger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMessanger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMessanger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMessanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessanger.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewMessanger.MultiSelect = false;
            this.dataGridViewMessanger.Name = "dataGridViewMessanger";
            this.dataGridViewMessanger.ReadOnly = true;
            this.dataGridViewMessanger.RowHeadersVisible = false;
            this.dataGridViewMessanger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessanger.Size = new System.Drawing.Size(776, 430);
            this.dataGridViewMessanger.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.database_toolStripComboBox,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // database_toolStripComboBox
            // 
            this.database_toolStripComboBox.Items.AddRange(new object[] {
            "Входящие",
            "Исходящие",
            "Внутренние"});
            this.database_toolStripComboBox.Name = "database_toolStripComboBox";
            this.database_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.database_toolStripComboBox.Text = "Выберите базу";
            this.database_toolStripComboBox.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::quality.Properties.Resources.application_add_12963;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::quality.Properties.Resources.application_edit_12962;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton2.Text = "Изменить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Image = global::quality.Properties.Resources.database_12929;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // MessengerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewMessanger);
            this.Name = "MessengerMain";
            this.Text = "Мессенджер";
            this.Load += new System.EventHandler(this.MessengerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessanger)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewMessanger;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox database_toolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}