
namespace quality.Directory.addDirectortData
{
    partial class GroupAndManufactur
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
            this.dataGridViewGroupAndManufactur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupAndManufactur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroupAndManufactur
            // 
            this.dataGridViewGroupAndManufactur.AllowUserToAddRows = false;
            this.dataGridViewGroupAndManufactur.AllowUserToDeleteRows = false;
            this.dataGridViewGroupAndManufactur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupAndManufactur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupAndManufactur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupAndManufactur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewGroupAndManufactur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupAndManufactur.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGroupAndManufactur.Name = "dataGridViewGroupAndManufactur";
            this.dataGridViewGroupAndManufactur.ReadOnly = true;
            this.dataGridViewGroupAndManufactur.RowHeadersVisible = false;
            this.dataGridViewGroupAndManufactur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroupAndManufactur.Size = new System.Drawing.Size(701, 440);
            this.dataGridViewGroupAndManufactur.TabIndex = 1;
            this.dataGridViewGroupAndManufactur.DoubleClick += new System.EventHandler(this.dataGridViewGroupAndManufactur_DoubleClick);
            // 
            // GroupAndManufactur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 464);
            this.Controls.Add(this.dataGridViewGroupAndManufactur);
            this.Name = "GroupAndManufactur";
            this.Text = "GroupAndManifactur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupAndManufactur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewGroupAndManufactur;
    }
}