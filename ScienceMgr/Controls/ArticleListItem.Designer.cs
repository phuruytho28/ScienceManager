namespace ScienceMgr.Controls
{
    partial class ArticleListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLink = new MetroFramework.Controls.MetroLink();
            this.authorsLabel = new MetroFramework.Controls.MetroLabel();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.keywordsLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // titleLink
            // 
            this.titleLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.titleLink.Location = new System.Drawing.Point(25, 40);
            this.titleLink.Name = "titleLink";
            this.titleLink.Size = new System.Drawing.Size(750, 58);
            this.titleLink.TabIndex = 0;
            this.titleLink.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,";
            this.titleLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLink.UseSelectable = true;
            this.titleLink.Click += new System.EventHandler(this.titleLink_Click);
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(25, 17);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(263, 20);
            this.authorsLabel.TabIndex = 1;
            this.authorsLabel.Text = "Nguyen Van A, Nguyen Van B, Tran Thi C";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 145);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Sửa";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(106, 145);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Location = new System.Drawing.Point(25, 101);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(209, 20);
            this.keywordsLabel.TabIndex = 4;
            this.keywordsLabel.Text = "Keyword1 Keyword2 Keyword3...";
            // 
            // ArticleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.keywordsLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.titleLink);
            this.Name = "ArticleListItem";
            this.Size = new System.Drawing.Size(940, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink titleLink;
        private MetroFramework.Controls.MetroLabel authorsLabel;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroLabel keywordsLabel;
    }
}
