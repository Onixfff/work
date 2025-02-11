
namespace quality.directory
{
    partial class BaseFormDirectory
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
            this.menuStripDictionary = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDirectory = new System.Windows.Forms.DataGridView();
            this.menuStripDictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripDictionary
            // 
            this.menuStripDictionary.AllowMerge = false;
            this.menuStripDictionary.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripDictionary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStripDictionary.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripDictionary.Location = new System.Drawing.Point(0, 0);
            this.menuStripDictionary.Name = "menuStripDictionary";
            this.menuStripDictionary.Size = new System.Drawing.Size(800, 24);
            this.menuStripDictionary.TabIndex = 1;
            this.menuStripDictionary.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::quality.Properties.Resources.application_add_12963;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Image = global::quality.Properties.Resources.application_edit_12962;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // dataGridViewDirectory
            // 
            this.dataGridViewDirectory.AllowUserToAddRows = false;
            this.dataGridViewDirectory.AllowUserToDeleteRows = false;
            this.dataGridViewDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDirectory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectory.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewDirectory.MultiSelect = false;
            this.dataGridViewDirectory.Name = "dataGridViewDirectory";
            this.dataGridViewDirectory.ReadOnly = true;
            this.dataGridViewDirectory.RowHeadersVisible = false;
            this.dataGridViewDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDirectory.Size = new System.Drawing.Size(776, 408);
            this.dataGridViewDirectory.TabIndex = 3;
            // 
            // BaseFormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDirectory);
            this.Controls.Add(this.menuStripDictionary);
            this.MainMenuStrip = this.menuStripDictionary;
            this.Name = "BaseFormDirectory";
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.BaseFormDirectory_Load);
            this.menuStripDictionary.ResumeLayout(false);
            this.menuStripDictionary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripDictionary;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewDirectory;
    }
}