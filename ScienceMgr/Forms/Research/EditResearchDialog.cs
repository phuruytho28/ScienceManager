using MetroFramework.Forms;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Forms.Research
{
    public partial class EditResearchDialog : MetroForm
    {
        private Models.Research research;
        private readonly int id;
        private readonly IUserRepository userRepository = new UserRepository();
        private readonly IResearchRepository researchRepository = new ResearchRepository();
        private List<User> selectedAuthors = new List<User>();

        public EditResearchDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        override protected async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                research = await researchRepository.GetResearchAsync(id);
                selectedAuthors = research.Researchers.ToList();
                titleTextBox.Text = research.Title;
                descriptionTextBox.Text = research.Description;
                keywordsTextBox.Text = research.Keywords;
                startDate.Value = research.StartDate;
                endDate.Value = research.EndDate;
                authorsCheckedListBox.CheckOnClick = true;
                authorsCheckedListBox.ItemCheck += authorsCheckedListBox_ItemCheck;
                authorsCheckedListBox.Items.Clear();
                var users = await userRepository.GetUsersAsync();
                foreach (var user in users)
                {
                    bool check = selectedAuthors.Any(a => a.Id == user.Id);
                    authorsCheckedListBox.Items.Add($"[{user.Id}] {user.Name}", check);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void authorsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var isChecked = e.NewValue == CheckState.Checked;
            string s = authorsCheckedListBox.Items[e.Index].ToString();
            var authorId = int.Parse(Regex.Match(s, @"\[(\d+)\]").Groups[1].Value);
            var author = await userRepository.GetUserAsync(authorId);
            if (isChecked)
            {
                if (!selectedAuthors.Any(a => a.Id == authorId))
                    selectedAuthors.Add(author);
            }
            else
            {
                var authorToRemove = selectedAuthors.FirstOrDefault(a => a.Id == authorId);
                if (authorToRemove != null)
                {
                    selectedAuthors.Remove(authorToRemove);
                }
            }
            authorsLabel.Text = string.Join(Environment.NewLine, selectedAuthors.Select(a => a.Name));

        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateData();
                research.Title = titleTextBox.Text.Trim();
                research.Keywords = keywordsTextBox.Text.Trim();
                research.Description = descriptionTextBox.Text.Trim();
                research.StartDate = startDate.Value;
                research.EndDate = endDate.Value;
                research.Researchers = selectedAuthors;
                await researchRepository.EditResearchAsync(research);
                DialogResult = DialogResult.OK;
                Close();


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateData()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                throw new Exception("Tiêu đề không được trống");
            }
            if (string.IsNullOrWhiteSpace(keywordsTextBox.Text))
            {
                throw new Exception("Từ khóa không được trống");
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                throw new Exception("Abstract không được trống");
            }
            if (startDate.Value > endDate.Value)
            {
                throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc");
            }
            if (selectedAuthors.Count == 0)
            {
                throw new Exception("Chưa có tác giả nào được chọn");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
