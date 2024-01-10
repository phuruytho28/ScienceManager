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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Forms.Article
{
    public partial class EditArticleDialog : MetroForm
    {
        private readonly int id;
        private Models.Article article;
        private readonly IArticleRepository articleRepository = new ArticleRepository();
        private readonly IUserRepository userRepository = new UserRepository();
        private List<User> selectedAuthors = new List<User>();

        public EditArticleDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                article = await articleRepository.GetArticleAsync(id);
                selectedAuthors = article.Authors.ToList();
                titleTextBox.Text = article.Title;
                abstractRichTextBox.Text = article.Abstract;
                keywordsTextBox.Text = article.Keywords;
                dateSubmissionPicker.Value = article.SubmissionDate;
                submissionAtTextBox.Text = article.SubmisstionAt;
                dateSubmissionPicker.MaxDate = DateTime.Now;
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
                if(!selectedAuthors.Any(a => a.Id == authorId))
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
                //article = new Models.Article
                //{
                //    Title = titleTextBox.Text.Trim(),
                //    Keywords = keywordsTextBox.Text.Trim(),
                //    Abstract = abstractRichTextBox.Text.Trim(),
                //    SubmisstionAt = submissionAtTextBox.Text.Trim(),
                //    SubmissionDate = dateSubmissionPicker.Value,
                //    Authors = selectedAuthors
                //};
                article.Title = titleTextBox.Text.Trim();
                article.Keywords = keywordsTextBox.Text.Trim();
                article.Abstract = abstractRichTextBox.Text.Trim();
                article.SubmisstionAt = submissionAtTextBox.Text.Trim();
                article.SubmissionDate = dateSubmissionPicker.Value;
                article.Authors = selectedAuthors;
                await articleRepository.EditArticleAsync(article);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
