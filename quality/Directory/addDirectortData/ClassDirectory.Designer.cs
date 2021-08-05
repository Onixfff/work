
namespace quality.Directory.addDirectortData
{
    partial class ClassDirectory
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
            this.labelComment = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(18, 102);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(69, 13);
            this.labelComment.TabIndex = 13;
            this.labelComment.Text = "Коментарий";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(107, 76);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(117, 67);
            this.richTextBoxComment.TabIndex = 2;
            this.richTextBoxComment.Text = "";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(77, 187);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(109, 49);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Добавить";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Наименование";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(117, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // ClassDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 248);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassDirectory";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseDirectoryAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}