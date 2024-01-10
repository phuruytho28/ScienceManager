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

namespace ScienceMgr.Forms.Article
{
    public partial class AddArticleDialog : MetroForm
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly IArticleRepository _articleRepository = new ArticleRepository();
        private List<User> selectedAuthors = new List<User>();
        public AddArticleDialog()
        {
            InitializeComponent();
        }

        override protected async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dateSubmissionPicker.MaxDate = DateTime.Now;
            authorsCheckedListBox.CheckOnClick = true;
            authorsCheckedListBox.ItemCheck += authorsCheckedListBox_ItemCheck;
            authorsCheckedListBox.Items.Clear();
            var users = await _userRepository.GetUsersAsync();
            foreach (var user in users)
            {
                authorsCheckedListBox.Items.Add($"[{user.Id}] {user.Name}");
            }
        }

        private async void authorsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var isChecked = e.NewValue == CheckState.Checked;
            string s = authorsCheckedListBox.Items[e.Index].ToString();
            var authorId = int.Parse(Regex.Match(s, @"\[(\d+)\]").Groups[1].Value);
            var author = await _userRepository.GetUserAsync(authorId);
            if (isChecked)
            {
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
            if (string.IsNullOrWhiteSpace(abstractRichTextBox.Text))
            {
                throw new Exception("Abstract không được trống");
            }
            if (string.IsNullOrWhiteSpace(submissionAtTextBox.Text))
            {
                throw new Exception("Nơi công bố không được trống");
            }
            if (selectedAuthors.Count == 0)
            {
                throw new Exception("Chưa có tác giả nào được chọn");
            }

            
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateData();
                var article = new Models.Article
                {
                    Title = titleTextBox.Text.Trim(),
                    Keywords = keywordsTextBox.Text.Trim(),
                    Abstract = abstractRichTextBox.Text.Trim(),
                    SubmisstionAt = submissionAtTextBox.Text.Trim(),
                    SubmissionDate = dateSubmissionPicker.Value,
                    Authors = selectedAuthors
                };
                await _articleRepository.AddArticleAsync(article);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
