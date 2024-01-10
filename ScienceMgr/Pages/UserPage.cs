using ScienceMgr.DbContext;
using ScienceMgr.Extensions;
using ScienceMgr.Forms;
using ScienceMgr.Models;
using ScienceMgr.Repositories.Abstraction;
using ScienceMgr.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Pages
{
    public partial class UserPage : Page
    {
        private readonly IUserRepository _userRepository;
        private User selectedUser;
        public UserPage()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                userGrid.SelectionChanged += UserGrid_SelectionChanged;
                await LoadData();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private async void UserGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count > 0)
            {
                var row = userGrid.SelectedRows[0];
                var id = int.Parse(row.Cells["Id"].Value.ToString());
                selectedUser = await _userRepository.GetUserAsync(id);
            }
            
        }

        private async Task LoadData()
        {
            Cursor = Cursors.WaitCursor;
            progressBar.Visible = true;
            userGrid.AutoGenerateColumns = true;
            var users = await  _userRepository.GetUsersAsync();
            var displayedUsers = users.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Gender = x.Gender == GenderType.Male ? "Nam" : "Nữ",
                BirthDate = x.BirthDate.ToString("dd/MM/yyyy"),
                Role = x.Role == RoleType.Student ? "Sinh viên" :
                        x.Role == RoleType.Postgraduate ? "Nghiên cứu sinh" :
                        "Giảng viên",
                Address = x.Address,
                Phone = x.Phone
            }).ToList();
            userGrid.DataSource = displayedUsers;
            userGrid.Columns["Id"].HeaderText = "Mã số";
            userGrid.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Name"].HeaderText = "Họ tên";
            userGrid.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Email"].HeaderText = "Email";
            userGrid.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Gender"].HeaderText = "Giới tính";
            userGrid.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["BirthDate"].HeaderText = "Ngày sinh";
            userGrid.Columns["BirthDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Role"].HeaderText = "Chức vụ";
            userGrid.Columns["Role"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Address"].HeaderText = "Địa chỉ";
            userGrid.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userGrid.Columns["Phone"].HeaderText = "Số điện thoại";
            userGrid.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Cursor = Cursors.Default;
            progressBar.Visible = false;
        }

        private async void addNewTile_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddNewUserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    await LoadData();
                }
            }
                
        }

        private async void editTile_Click(object sender, EventArgs e)
        {
            using (var dialog = new EditUserDialog(selectedUser))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    userGrid.DataSource = null;
                    userGrid.Rows.Clear();
                    await LoadData();
                }
            }
                

        }

        private async void deleteTile_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
                return;
            string message = $"Bạn có chắc chắn muốn xóa người dùng '{selectedUser.Name}' có id '{selectedUser.Id}'?";
            if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _userRepository.DeleteUserAsync(selectedUser.Id);
                await LoadData();
            }
        }
    }
}
