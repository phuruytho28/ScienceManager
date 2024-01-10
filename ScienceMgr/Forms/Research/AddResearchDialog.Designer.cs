namespace ScienceMgr.Forms.Research
{
    partial class AddResearchDialog
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
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.keywordsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.authorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.authorsLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(687, 540);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 38);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(223, 540);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(119, 38);
            this.okButton.TabIndex = 34;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(561, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(223, 154);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(583, 23);
            this.descriptionTextBox.TabIndex = 30;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // titleTextBox
            // 
            // 
            // 
            // 
            this.titleTextBox.CustomButton.Image = null;
            this.titleTextBox.CustomButton.Location = new System.Drawing.Point(561, 1);
            this.titleTextBox.CustomButton.Name = "";
            this.titleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleTextBox.CustomButton.TabIndex = 1;
            this.titleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTextBox.CustomButton.UseSelectable = true;
            this.titleTextBox.CustomButton.Visible = false;
            this.titleTextBox.Lines = new string[0];
            this.titleTextBox.Location = new System.Drawing.Point(223, 103);
            this.titleTextBox.MaxLength = 32767;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.SelectionLength = 0;
            this.titleTextBox.SelectionStart = 0;
            this.titleTextBox.ShortcutsEnabled = true;
            this.titleTextBox.Size = new System.Drawing.Size(583, 23);
            this.titleTextBox.TabIndex = 29;
            this.titleTextBox.UseSelectable = true;
            this.titleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 20);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Mô tả";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 20);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Đề tài";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(223, 196);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(349, 30);
            this.startDate.TabIndex = 36;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 196);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 20);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Ngày bắt đầu";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 244);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 20);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Ngày kết thúc";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(223, 244);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(349, 30);
            this.endDate.TabIndex = 39;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 303);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 20);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Từ khóa";
            // 
            // keywordsTextBox
            // 
            // 
            // 
            // 
            this.keywordsTextBox.CustomButton.Image = null;
            this.keywordsTextBox.CustomButton.Location = new System.Drawing.Point(561, 1);
            this.keywordsTextBox.CustomButton.Name = "";
            this.keywordsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keywordsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywordsTextBox.CustomButton.TabIndex = 1;
            this.keywordsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywordsTextBox.CustomButton.UseSelectable = true;
            this.keywordsTextBox.CustomButton.Visible = false;
            this.keywordsTextBox.Lines = new string[0];
            this.keywordsTextBox.Location = new System.Drawing.Point(223, 303);
            this.keywordsTextBox.MaxLength = 32767;
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.PasswordChar = '\0';
            this.keywordsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keywordsTextBox.SelectedText = "";
            this.keywordsTextBox.SelectionLength = 0;
            this.keywordsTextBox.SelectionStart = 0;
            this.keywordsTextBox.ShortcutsEnabled = true;
            this.keywordsTextBox.Size = new System.Drawing.Size(583, 23);
            this.keywordsTextBox.TabIndex = 41;
            this.keywordsTextBox.UseSelectable = true;
            this.keywordsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keywordsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 372);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 20);
            this.metroLabel5.TabIndex = 42;
            this.metroLabel5.Text = "Nghiên cứu bởi";
            // 
            // authorsCheckedListBox
            // 
            this.authorsCheckedListBox.FormattingEnabled = true;
            this.authorsCheckedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.authorsCheckedListBox.Location = new System.Drawing.Point(223, 372);
            this.authorsCheckedListBox.Name = "authorsCheckedListBox";
            this.authorsCheckedListBox.Size = new System.Drawing.Size(273, 140);
            this.authorsCheckedListBox.TabIndex = 43;
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(502, 372);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(0, 0);
            this.authorsLabel.TabIndex = 44;
            // 
            // AddResearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 604);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.authorsCheckedListBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.keywordsTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddResearchDialog";
            this.Text = "Thêm đề tài nghiên cứu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox titleTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox keywordsTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.CheckedListBox authorsCheckedListBox;
        private MetroFramework.Controls.MetroLabel authorsLabel;
    }
}