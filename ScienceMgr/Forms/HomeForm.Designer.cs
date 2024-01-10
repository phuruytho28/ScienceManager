namespace ScienceMgr
{
    partial class HomeForm
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
            this.leftPanel = new MetroFramework.Controls.MetroPanel();
            this.homeLink = new MetroFramework.Controls.MetroLink();
            this.rightPanel = new MetroFramework.Controls.MetroPanel();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.homeLink);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.HorizontalScrollbarBarColor = true;
            this.leftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftPanel.HorizontalScrollbarSize = 8;
            this.leftPanel.Location = new System.Drawing.Point(15, 60);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(58, 624);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.VerticalScrollbarBarColor = true;
            this.leftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftPanel.VerticalScrollbarSize = 8;
            // 
            // homeLink
            // 
            this.homeLink.BackgroundImage = global::ScienceMgr.Properties.Resources._128_home;
            this.homeLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLink.Location = new System.Drawing.Point(3, 3);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(43, 59);
            this.homeLink.TabIndex = 4;
            this.homeLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeLink.UseSelectable = true;
            this.homeLink.Click += new System.EventHandler(this.homeLink_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.HorizontalScrollbarBarColor = true;
            this.rightPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightPanel.HorizontalScrollbarSize = 8;
            this.rightPanel.Location = new System.Drawing.Point(73, 60);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1044, 624);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.VerticalScrollbarBarColor = true;
            this.rightPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightPanel.VerticalScrollbarSize = 8;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 700);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Quản Lý Khoa Học";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel leftPanel;
        private MetroFramework.Controls.MetroPanel rightPanel;
        private MetroFramework.Controls.MetroLink homeLink;
    }
}

