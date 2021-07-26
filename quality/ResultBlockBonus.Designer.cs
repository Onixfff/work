
namespace quality
{
    partial class ResultBlockBonus
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
            this.dataGridView_ResultBlock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ResultBlock
            // 
            this.dataGridView_ResultBlock.AllowUserToAddRows = false;
            this.dataGridView_ResultBlock.AllowUserToDeleteRows = false;
            this.dataGridView_ResultBlock.AllowUserToResizeColumns = false;
            this.dataGridView_ResultBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ResultBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ResultBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ResultBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ResultBlock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_ResultBlock.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ResultBlock.Name = "dataGridView_ResultBlock";
            this.dataGridView_ResultBlock.ReadOnly = true;
            this.dataGridView_ResultBlock.RowHeadersVisible = false;
            this.dataGridView_ResultBlock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ResultBlock.Size = new System.Drawing.Size(776, 426);
            this.dataGridView_ResultBlock.TabIndex = 2;
            // 
            // ResultBlockBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ResultBlock);
            this.Name = "ResultBlockBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultBlockBonus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_ResultBlock;
    }
}