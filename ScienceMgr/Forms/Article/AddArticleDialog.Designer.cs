namespace ScienceMgr.Forms.Article
{
    partial class AddArticleDialog
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.titleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.keywordsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.abstractRichTextBox = new System.Windows.Forms.RichTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateSubmissionPicker = new MetroFramework.Controls.MetroDateTime();
            this.submissionAtTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.authorsLabel = new MetroFramework.Controls.MetroLabel();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tiêu đề";
            // 
            // titleTextBox
            // 
            // 
            // 
            // 
            this.titleTextBox.CustomButton.Image = null;
            this.titleTextBox.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.titleTextBox.CustomButton.Name = "";
            this.titleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleTextBox.CustomButton.TabIndex = 1;
            this.titleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTextBox.CustomButton.UseSelectable = true;
            this.titleTextBox.CustomButton.Visible = false;
            this.titleTextBox.Lines = new string[0];
            this.titleTextBox.Location = new System.Drawing.Point(168, 79);
            this.titleTextBox.MaxLength = 32767;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.SelectionLength = 0;
            this.titleTextBox.SelectionStart = 0;
            this.titleTextBox.ShortcutsEnabled = true;
            this.titleTextBox.Size = new System.Drawing.Size(524, 23);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.UseSelectable = true;
            this.titleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keywordsTextBox
            // 
            // 
            // 
            // 
            this.keywordsTextBox.CustomButton.Image = null;
            this.keywordsTextBox.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.keywordsTextBox.CustomButton.Name = "";
            this.keywordsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keywordsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywordsTextBox.CustomButton.TabIndex = 1;
            this.keywordsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywordsTextBox.CustomButton.UseSelectable = true;
            this.keywordsTextBox.CustomButton.Visible = false;
            this.keywordsTextBox.Lines = new string[0];
            this.keywordsTextBox.Location = new System.Drawing.Point(168, 121);
            this.keywordsTextBox.MaxLength = 32767;
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.PasswordChar = '\0';
            this.keywordsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keywordsTextBox.SelectedText = "";
            this.keywordsTextBox.SelectionLength = 0;
            this.keywordsTextBox.SelectionStart = 0;
            this.keywordsTextBox.ShortcutsEnabled = true;
            this.keywordsTextBox.Size = new System.Drawing.Size(524, 23);
            this.keywordsTextBox.TabIndex = 3;
            this.keywordsTextBox.UseSelectable = true;
            this.keywordsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keywordsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Từ khóa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Abstract";
            // 
            // abstractRichTextBox
            // 
            this.abstractRichTextBox.Location = new System.Drawing.Point(168, 167);
            this.abstractRichTextBox.Name = "abstractRichTextBox";
            this.abstractRichTextBox.Size = new System.Drawing.Size(524, 217);
            this.abstractRichTextBox.TabIndex = 5;
            this.abstractRichTextBox.Text = "";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 390);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Ngày công bố";
            // 
            // dateSubmissionPicker
            // 
            this.dateSubmissionPicker.CustomFormat = "dd/MM/yyyy";
            this.dateSubmissionPicker.Location = new System.Drawing.Point(168, 390);
            this.dateSubmissionPicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateSubmissionPicker.Name = "dateSubmissionPicker";
            this.dateSubmissionPicker.Size = new System.Drawing.Size(200, 30);
            this.dateSubmissionPicker.TabIndex = 7;
            // 
            // submissionAtTextBox
            // 
            // 
            // 
            // 
            this.submissionAtTextBox.CustomButton.Image = null;
            this.submissionAtTextBox.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.submissionAtTextBox.CustomButton.Name = "";
            this.submissionAtTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.submissionAtTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.submissionAtTextBox.CustomButton.TabIndex = 1;
            this.submissionAtTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.submissionAtTextBox.CustomButton.UseSelectable = true;
            this.submissionAtTextBox.CustomButton.Visible = false;
            this.submissionAtTextBox.Lines = new string[0];
            this.submissionAtTextBox.Location = new System.Drawing.Point(168, 439);
            this.submissionAtTextBox.MaxLength = 32767;
            this.submissionAtTextBox.Name = "submissionAtTextBox";
            this.submissionAtTextBox.PasswordChar = '\0';
            this.submissionAtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.submissionAtTextBox.SelectedText = "";
            this.submissionAtTextBox.SelectionLength = 0;
            this.submissionAtTextBox.SelectionStart = 0;
            this.submissionAtTextBox.ShortcutsEnabled = true;
            this.submissionAtTextBox.Size = new System.Drawing.Size(524, 23);
            this.submissionAtTextBox.TabIndex = 9;
            this.submissionAtTextBox.UseSelectable = true;
            this.submissionAtTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.submissionAtTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 439);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Nơi công bố";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 488);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Tác giả";
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(442, 488);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(0, 0);
            this.authorsLabel.TabIndex = 11;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(168, 651);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(116, 39);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(576, 651);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 39);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.authorsCheckedListBox);
            this.panel1.Location = new System.Drawing.Point(168, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 122);
            this.panel1.TabIndex = 15;
            // 
            // authorsCheckedListBox
            // 
            this.authorsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.authorsCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.authorsCheckedListBox.Name = "authorsCheckedListBox";
            this.authorsCheckedListBox.Size = new System.Drawing.Size(268, 122);
            this.authorsCheckedListBox.TabIndex = 16;
            // 
            // AddArticleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.submissionAtTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dateSubmissionPicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.abstractRichTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.keywordsTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddArticleDialog";
            this.Text = "Thêm bài báo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox titleTextBox;
        private MetroFramework.Controls.MetroTextBox keywordsTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox abstractRichTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dateSubmissionPicker;
        private MetroFramework.Controls.MetroTextBox submissionAtTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel authorsLabel;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox authorsCheckedListBox;
    }
}