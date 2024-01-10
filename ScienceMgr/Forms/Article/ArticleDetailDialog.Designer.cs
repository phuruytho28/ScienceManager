namespace ScienceMgr.Forms.Article
{
    partial class ArticleDetailDialog
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
            this.authorsLabel = new MetroFramework.Controls.MetroLabel();
            this.keywordLabel = new MetroFramework.Controls.MetroLabel();
            this.submissionAtLabel = new MetroFramework.Controls.MetroLabel();
            this.submissionDateLabel = new MetroFramework.Controls.MetroLabel();
            this.abstractRichTextBox = new System.Windows.Forms.RichTextBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(23, 77);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(58, 20);
            this.authorsLabel.TabIndex = 0;
            this.authorsLabel.Text = "Tác giả: ";
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(23, 116);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(66, 20);
            this.keywordLabel.TabIndex = 1;
            this.keywordLabel.Text = "Từ khóa: ";
            // 
            // submissionAtLabel
            // 
            this.submissionAtLabel.AutoSize = true;
            this.submissionAtLabel.Location = new System.Drawing.Point(23, 158);
            this.submissionAtLabel.Name = "submissionAtLabel";
            this.submissionAtLabel.Size = new System.Drawing.Size(87, 20);
            this.submissionAtLabel.TabIndex = 2;
            this.submissionAtLabel.Text = "Công bố tại: ";
            // 
            // submissionDateLabel
            // 
            this.submissionDateLabel.AutoSize = true;
            this.submissionDateLabel.Location = new System.Drawing.Point(23, 194);
            this.submissionDateLabel.Name = "submissionDateLabel";
            this.submissionDateLabel.Size = new System.Drawing.Size(97, 20);
            this.submissionDateLabel.TabIndex = 3;
            this.submissionDateLabel.Text = "Ngày công bố";
            // 
            // abstractRichTextBox
            // 
            this.abstractRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.abstractRichTextBox.Location = new System.Drawing.Point(23, 238);
            this.abstractRichTextBox.Name = "abstractRichTextBox";
            this.abstractRichTextBox.ReadOnly = true;
            this.abstractRichTextBox.Size = new System.Drawing.Size(1234, 387);
            this.abstractRichTextBox.TabIndex = 4;
            this.abstractRichTextBox.Text = "";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(23, 658);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 39);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ArticleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.abstractRichTextBox);
            this.Controls.Add(this.submissionDateLabel);
            this.Controls.Add(this.submissionAtLabel);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.authorsLabel);
            this.Name = "ArticleDetailForm";
            this.Text = "ArticleDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel authorsLabel;
        private MetroFramework.Controls.MetroLabel keywordLabel;
        private MetroFramework.Controls.MetroLabel submissionAtLabel;
        private MetroFramework.Controls.MetroLabel submissionDateLabel;
        private System.Windows.Forms.RichTextBox abstractRichTextBox;
        private MetroFramework.Controls.MetroButton okButton;
    }
}