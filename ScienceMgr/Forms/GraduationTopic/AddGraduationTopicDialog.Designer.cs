namespace ScienceMgr.Forms.GraduationTopic
{
    partial class AddGraduationTopicDialog
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
            this.lecturersComboBox = new MetroFramework.Controls.MetroComboBox();
            this.studentsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.gradeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.topicTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(687, 386);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 38);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(223, 386);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(119, 38);
            this.okButton.TabIndex = 22;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lecturersComboBox
            // 
            this.lecturersComboBox.FormattingEnabled = true;
            this.lecturersComboBox.ItemHeight = 24;
            this.lecturersComboBox.Location = new System.Drawing.Point(223, 246);
            this.lecturersComboBox.Name = "lecturersComboBox";
            this.lecturersComboBox.Size = new System.Drawing.Size(333, 30);
            this.lecturersComboBox.TabIndex = 21;
            this.lecturersComboBox.UseSelectable = true;
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.ItemHeight = 24;
            this.studentsComboBox.Location = new System.Drawing.Point(223, 192);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(333, 30);
            this.studentsComboBox.TabIndex = 20;
            this.studentsComboBox.UseSelectable = true;
            // 
            // gradeTextBox
            // 
            // 
            // 
            // 
            this.gradeTextBox.CustomButton.Image = null;
            this.gradeTextBox.CustomButton.Location = new System.Drawing.Point(561, 1);
            this.gradeTextBox.CustomButton.Name = "";
            this.gradeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gradeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gradeTextBox.CustomButton.TabIndex = 1;
            this.gradeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gradeTextBox.CustomButton.UseSelectable = true;
            this.gradeTextBox.CustomButton.Visible = false;
            this.gradeTextBox.Lines = new string[0];
            this.gradeTextBox.Location = new System.Drawing.Point(223, 301);
            this.gradeTextBox.MaxLength = 32767;
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.PasswordChar = '\0';
            this.gradeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gradeTextBox.SelectedText = "";
            this.gradeTextBox.SelectionLength = 0;
            this.gradeTextBox.SelectionStart = 0;
            this.gradeTextBox.ShortcutsEnabled = true;
            this.gradeTextBox.Size = new System.Drawing.Size(583, 23);
            this.gradeTextBox.TabIndex = 19;
            this.gradeTextBox.UseSelectable = true;
            this.gradeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gradeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(223, 151);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(583, 23);
            this.descriptionTextBox.TabIndex = 18;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // topicTextBox
            // 
            // 
            // 
            // 
            this.topicTextBox.CustomButton.Image = null;
            this.topicTextBox.CustomButton.Location = new System.Drawing.Point(561, 1);
            this.topicTextBox.CustomButton.Name = "";
            this.topicTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.topicTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.topicTextBox.CustomButton.TabIndex = 1;
            this.topicTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.topicTextBox.CustomButton.UseSelectable = true;
            this.topicTextBox.CustomButton.Visible = false;
            this.topicTextBox.Lines = new string[0];
            this.topicTextBox.Location = new System.Drawing.Point(223, 100);
            this.topicTextBox.MaxLength = 32767;
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.PasswordChar = '\0';
            this.topicTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.topicTextBox.SelectedText = "";
            this.topicTextBox.SelectionLength = 0;
            this.topicTextBox.SelectionStart = 0;
            this.topicTextBox.ShortcutsEnabled = true;
            this.topicTextBox.Size = new System.Drawing.Size(583, 23);
            this.topicTextBox.TabIndex = 17;
            this.topicTextBox.UseSelectable = true;
            this.topicTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.topicTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Điểm";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 251);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Giáo viên hướng dẫn";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 197);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Sinh viên bảo vệ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 20);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Mô tả";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 20);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Đề tài";
            // 
            // AddGraduationTopicDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 459);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lecturersComboBox);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddGraduationTopicDialog";
            this.Text = "Thêm khóa luận tốt nghiệp/đồ án tốt nghiệp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroComboBox lecturersComboBox;
        private MetroFramework.Controls.MetroComboBox studentsComboBox;
        private MetroFramework.Controls.MetroTextBox gradeTextBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox topicTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}