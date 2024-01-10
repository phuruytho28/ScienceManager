using MetroFramework.Forms;
using ScienceMgr.Repositories.Abstraction;
using ScienceMgr.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Forms.GraduationTopic
{
    public partial class EditGraduationTopicDialog : MetroForm
    {
        private readonly Models.GraduationTopic topic;
        private readonly IGraduationTopicRepository _graduationTopicRepository = new GraduationTopicRepository();
        private readonly IUserRepository _userRepository = new UserRepository();

        public EditGraduationTopicDialog(Models.GraduationTopic topic)
        {
            InitializeComponent();
            this.topic = topic;
        }
        protected async override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                var students = await _userRepository.GetStudents();
                var lecturers = await _userRepository.GetLecturers();
                var postgraduates = await _userRepository.GetPostgraduates();
                studentsComboBox.DataSource = students;
                studentsComboBox.DisplayMember = "Name";
                studentsComboBox.SelectedIndex = -1;
                lecturersComboBox.DataSource = lecturers;
                lecturersComboBox.DisplayMember = "Name";
                lecturersComboBox.SelectedIndex = -1;
                topicTextBox.Text = topic.Topic;
                descriptionTextBox.Text = topic.Description;
                gradeTextBox.Text = topic.Grade.ToString();
                studentsComboBox.SelectedItem = students.FirstOrDefault(x => x.Id == topic.StudentId);
                lecturersComboBox.SelectedItem = lecturers.FirstOrDefault(x => x.Id == topic.SupervisorId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
                topic.Topic = topicTextBox.Text.Trim();
                topic.Description = descriptionTextBox.Text.Trim();
                topic.Grade = float.Parse(gradeTextBox.Text);
                topic.StudentId = (studentsComboBox.SelectedItem as Models.User).Id;
                topic.SupervisorId = (lecturersComboBox.SelectedItem as Models.User).Id;
                _graduationTopicRepository.EditGraduationTopic(topic);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ValidateData()
        {
            if (studentsComboBox.SelectedIndex == -1)
            {
                throw new Exception("Sinh viên không được để trống");
            }
            if (lecturersComboBox.SelectedIndex == -1)
            {
                throw new Exception("Giảng viên không được để trống");
            }
            if (string.IsNullOrWhiteSpace(topicTextBox.Text))
            {
                throw new Exception("Tên đề tài không được để trống");
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                throw new Exception("Mô tả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(gradeTextBox.Text))
            {
                throw new Exception("Điểm không được để trống");
            }
            if (float.TryParse(gradeTextBox.Text, out float grade))
            {
                if (grade < 0 || grade > 10)
                {
                    throw new Exception("Điểm phải nằm trong khoảng từ 0 đến 10");
                }
            }
            else
            {
                throw new Exception("Điểm phải là số");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
