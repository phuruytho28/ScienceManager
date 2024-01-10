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
    public partial class AddNewUserDialog : MetroForm
    {
        private readonly IUserRepository _userRepository;
        public AddNewUserDialog()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            genderComboBox.SelectedIndex = 0;
            roleComboBox.SelectedIndex = 2;
            birthDatePicker.MaxDate = DateTime.Now;
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateData();
                var user = new User()
                {
                    Name = nameTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    Address = addressTextBox.Text.Trim(),
                    Phone = phoneTextBox.Text.Trim(),
                    BirthDate = birthDatePicker.Value
                };
                user.Gender = genderComboBox.SelectedIndex == 0 ? GenderType.Male : GenderType.Female;
                user.Role = roleComboBox.SelectedIndex == 0 ? RoleType.Lecturer :
                            roleComboBox.SelectedIndex == 1 ? RoleType.Postgraduate :
                            RoleType.Student;
                await _userRepository.AddUserAsync(user);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
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
        override protected void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }
}
