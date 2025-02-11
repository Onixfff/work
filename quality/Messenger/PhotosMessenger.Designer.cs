
namespace quality.Messenger
{
    partial class PhotosMessenger
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.delitePhoto = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelCoins = new System.Windows.Forms.Label();
            this.submitPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxMessenger = new System.Windows.Forms.PictureBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessenger)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.delitePhoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLeft, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRight, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCoins, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.submitPhoto, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCloseForm, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 474);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // delitePhoto
            // 
            this.delitePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delitePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delitePhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delitePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delitePhoto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delitePhoto.Location = new System.Drawing.Point(3, 3);
            this.delitePhoto.Name = "delitePhoto";
            this.delitePhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delitePhoto.Size = new System.Drawing.Size(179, 55);
            this.delitePhoto.TabIndex = 7;
            this.delitePhoto.Text = "Удалить\r\n";
            this.delitePhoto.UseVisualStyleBackColor = true;
            this.delitePhoto.Click += new System.EventHandler(this.delitePhoto_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(188, 3);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(133, 55);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.Text = "<\r\n";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(419, 3);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(133, 55);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">\r\n";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCoins.Location = new System.Drawing.Point(327, 0);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(86, 61);
            this.labelCoins.TabIndex = 3;
            this.labelCoins.Text = "0-0";
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitPhoto
            // 
            this.submitPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitPhoto.Location = new System.Drawing.Point(558, 3);
            this.submitPhoto.Name = "submitPhoto";
            this.submitPhoto.Size = new System.Drawing.Size(179, 55);
            this.submitPhoto.TabIndex = 2;
            this.submitPhoto.Text = "Загрузить изображение";
            this.submitPhoto.UseVisualStyleBackColor = true;
            this.submitPhoto.Click += new System.EventHandler(this.submitPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxMessenger
            // 
            this.pictureBoxMessenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMessenger.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMessenger.Name = "pictureBoxMessenger";
            this.pictureBoxMessenger.Size = new System.Drawing.Size(929, 474);
            this.pictureBoxMessenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMessenger.TabIndex = 1;
            this.pictureBoxMessenger.TabStop = false;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Image = global::quality.Properties.Resources.database_add_12927;
            this.buttonCloseForm.Location = new System.Drawing.Point(743, 3);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(183, 55);
            this.buttonCloseForm.TabIndex = 8;
            this.buttonCloseForm.Text = "Сохранить";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // PhotosMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 535);
            this.Controls.Add(this.pictureBoxMessenger);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhotosMessenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotosMessenger";
            this.Load += new System.EventHandler(this.PhotosMessenger_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessenger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delitePhoto;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Button submitPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMessenger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}