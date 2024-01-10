namespace ScienceMgr.Pages
{
    partial class HomePage
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
            this.userTile = new MetroFramework.Controls.MetroTile();
            this.articleTile = new MetroFramework.Controls.MetroTile();
            this.researchTile = new MetroFramework.Controls.MetroTile();
            this.graduationTopicTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // userTile
            // 
            this.userTile.ActiveControl = null;
            this.userTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userTile.Location = new System.Drawing.Point(21, 18);
            this.userTile.Name = "userTile";
            this.userTile.Size = new System.Drawing.Size(219, 186);
            this.userTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.userTile.TabIndex = 0;
            this.userTile.Text = "Cán bộ/Học viên";
            this.userTile.TileImage = global::ScienceMgr.Properties.Resources._128__people;
            this.userTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.userTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.userTile.UseSelectable = true;
            this.userTile.UseTileImage = true;
            this.userTile.Click += new System.EventHandler(this.userTile_Click);
            // 
            // articleTile
            // 
            this.articleTile.ActiveControl = null;
            this.articleTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.articleTile.Location = new System.Drawing.Point(246, 18);
            this.articleTile.Name = "articleTile";
            this.articleTile.Size = new System.Drawing.Size(219, 186);
            this.articleTile.Style = MetroFramework.MetroColorStyle.Green;
            this.articleTile.TabIndex = 1;
            this.articleTile.Text = "Bài báo";
            this.articleTile.TileImage = global::ScienceMgr.Properties.Resources._128_article;
            this.articleTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.articleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.articleTile.UseSelectable = true;
            this.articleTile.UseTileImage = true;
            this.articleTile.Click += new System.EventHandler(this.articleTile_Click);
            // 
            // researchTile
            // 
            this.researchTile.ActiveControl = null;
            this.researchTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.researchTile.Location = new System.Drawing.Point(21, 215);
            this.researchTile.Name = "researchTile";
            this.researchTile.Size = new System.Drawing.Size(219, 186);
            this.researchTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.researchTile.TabIndex = 2;
            this.researchTile.Text = "Nghiên cứu khoa học";
            this.researchTile.TileImage = global::ScienceMgr.Properties.Resources._128_reseach;
            this.researchTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.researchTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.researchTile.UseSelectable = true;
            this.researchTile.UseTileImage = true;
            this.researchTile.Click += new System.EventHandler(this.researchTile_Click);
            // 
            // graduationTopicTile
            // 
            this.graduationTopicTile.ActiveControl = null;
            this.graduationTopicTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graduationTopicTile.Location = new System.Drawing.Point(246, 215);
            this.graduationTopicTile.Name = "graduationTopicTile";
            this.graduationTopicTile.Size = new System.Drawing.Size(219, 186);
            this.graduationTopicTile.TabIndex = 3;
            this.graduationTopicTile.Text = "Đề tài tốt nghiệp";
            this.graduationTopicTile.TileImage = global::ScienceMgr.Properties.Resources._128_graduate;
            this.graduationTopicTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.graduationTopicTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.graduationTopicTile.UseSelectable = true;
            this.graduationTopicTile.UseTileImage = true;
            this.graduationTopicTile.Click += new System.EventHandler(this.graduationTopicTile_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graduationTopicTile);
            this.Controls.Add(this.researchTile);
            this.Controls.Add(this.articleTile);
            this.Controls.Add(this.userTile);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(867, 635);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile userTile;
        private MetroFramework.Controls.MetroTile articleTile;
        private MetroFramework.Controls.MetroTile researchTile;
        private MetroFramework.Controls.MetroTile graduationTopicTile;
    }
}
