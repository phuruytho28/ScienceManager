using MetroFramework.Forms;
using ScienceMgr.DbContext;
using ScienceMgr.Models;
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

namespace ScienceMgr.Forms
{
    public partial class EditUserDialog : MetroForm
    {
        RoleType role;
        GenderType gender;
        private readonly IUserRepository _userRepository;
        public User User { get; }
        public EditUserDialog(User user)
        {
            InitializeComponent();
            User = user;
            _userRepository = new UserRepository();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // TODO: Lỗi khi chọn giới tính và Role 
            nameTextBox.Text = User.Name;
            emailTextBox.Text = User.Email;
            addressTextBox.Text = User.Address;
            phoneTextBox.Text = User.Phone;
            birthDatePicker.Value = User.BirthDate;
            genderComboBox.SelectedIndex = (int)User.Gender;
            roleComboBox.SelectedIndex = (int)User.Role;

        }
        private async void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateData();
                
                switch (roleComboBox.SelectedIndex)
                {
                    case 0:
                        role = RoleType.Lecturer;
                        break;
                    case 1:
                        role = RoleType.Postgraduate;
                        break;
                    default:
                        role = RoleType.Student;
                        break;
                }
                var user = new User()
                {
                    Id = User.Id,
                    Name = nameTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    Address = addressTextBox.Text.Trim(),
                    Phone = phoneTextBox.Text.Trim(),
                    BirthDate = birthDatePicker.Value,
                    Gender = gender,
                    Role = role
                };
                await _userRepository.EditUserAsync(user);

                DialogResult = DialogResult.OK;
                Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void validateData()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                throw new Exception("Tên không được để trống");
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                throw new Exception("Email không được để trống");
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                throw new Exception("Địa chỉ không được để trống");
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                throw new Exception("Số điện thoại không được để trống");
            }
            if (birthDatePicker.Value == null)
            {
                throw new Exception("Ngày sinh không được để trống");
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = (GenderType)genderComboBox.SelectedIndex;
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = (RoleType)roleComboBox.SelectedIndex;
        }
    }
}
