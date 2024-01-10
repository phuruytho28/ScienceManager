using ScienceMgr.DbContext;
using ScienceMgr.Forms.Article;
using ScienceMgr.Models;
using ScienceMgr.Repositories.Abstraction;
using ScienceMgr.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Pages
{
    public partial class ArticlePage : Page
    {
        private readonly IArticleRepository articleRepository = new ArticleRepository();
        private ICollection<Article> articles = new List<Article>();


        public ArticlePage()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            try {
                base.OnLoad(e);
                this.AutoScroll = true;
                flowLayoutPanel.VerticalScroll.Visible = true;
                searchTextBox.KeyDown += async (s, ev) =>
                {
                    if (ev.KeyCode == Keys.Enter)
                    {
                        await performSearch();
                    }
                };

                articles = await GetArticlesAsync();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadDataAsync()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var article in articles)
            {
                var item = new Controls.ArticleListItem
                {
                    Id = article.Id,
                    Authors = string.Join(", ", article.Authors.Select(a => a.Name)),
                    Title = article.Title,
                    Keywords = article.Keywords
                };
                flowLayoutPanel.Controls.Add(item);
                item.editButtonClicked += EditArticle;
                item.deleteButtonClicked += DeleteArticleAsync;
                item.titleLinkClicked += ShowArticleDetail;
            }
        }


        private Task<ICollection<Article>> GetDummyArticlesAsync()
        {
            var list = new List<Article>
                    {
                        new Article
                        {
                            Title = "Bài báo 1",
                            Abstract = "Tóm tắt bài báo 1",
                            Keywords = "Từ khóa bài báo 1",
                            SubmissionDate = DateTime.Now,
                            SubmisstionAt = "Nơi nộp bài báo 1",
                            Authors = new List<User>
                            {
                                new User
                                {
                                    Name = "Nguyễn Văn A"
                                },
                                new User
                                {
                                    Name = "Nguyễn Văn B"
                                }
                            }
                        },
                        new Article
                        {
                            Title = "Bài báo 2",
                            Abstract = "Tóm tắt bài báo 2",
                            Keywords = "Từ khóa bài báo 2",
                            SubmissionDate = DateTime.Now,
                            SubmisstionAt = "Nơi nộp bài báo 2",
                            Authors = new List<User>
                            {
                                new User
                                {
                                    Name = "Nguyễn Văn C"
                                },
                                new User
                                {
                                    Name = "Nguyễn Văn D"
                                }
                            }
                        }
                    };
            return Task.FromResult<ICollection<Article>>(list);
        }
        private async Task<ICollection<Article>> GetArticlesAsync()
        {
            return await articleRepository.GetArticlesAsync();
        }

        private async void addTile_Click(object sender, EventArgs e)
        {
            using (var dialog = new Forms.Article.AddArticleDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    articles = await GetArticlesAsync();
                    await LoadDataAsync();

                }
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            await performSearch();
        }

        private async Task performSearch()
        {
            string searchKey = searchTextBox.Text.Trim();  
            var r1 = (await articleRepository.GetArticlesByTitleAsync(searchKey)).Select(a => a.Id);
            var r2 = (await articleRepository.GetArticlesByKeywordAsync(searchKey)).Select(a => a.Id);
            var r3 = (await articleRepository.GetArticlesByAuthorNameAsync(searchKey)).Select(a => a.Id);
            var ids = r1.Union(r2).Union(r3).ToList();
            articles = (await GetArticlesAsync()).Where(a => ids.Contains(a.Id)).ToList();
            await LoadDataAsync();
        }

        public async void DeleteArticleAsync(object sender, int id)
        {
            var article = await articleRepository.GetArticleAsync(id);
            if (MessageBox.Show($"Ban có muốn xóa bài báo \"{article.Title}\"?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                await articleRepository.DeleteArticleAsync(id);
                articles = await GetArticlesAsync();
                await LoadDataAsync();
                MessageBox.Show($"Đã xóa bài báo \"{article.Title}\"");
            }

        }
        private async void EditArticle(object sender, int id)
        {
            using (var editDialog = new EditArticleDialog(id))
            {
                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    articles = await GetArticlesAsync();
                    await LoadDataAsync();
                }
            }
        }
        private void ShowArticleDetail(object sender, int id)
        {
            using (var detailDialog = new ArticleDetailDialog(id))
            {
                detailDialog.ShowDialog();
            }
        }
    }
}
