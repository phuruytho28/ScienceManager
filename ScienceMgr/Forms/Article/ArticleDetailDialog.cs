using MetroFramework.Forms;
using ScienceMgr.Repositories.Abstraction;
using ScienceMgr.Repositories.Implementation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScienceMgr.Forms.Article
{
    public partial class ArticleDetailDialog : MetroForm
    {
        private readonly int id;
        private readonly IArticleRepository _articleRepository = new ArticleRepository();
        private Models.Article article;    
        public ArticleDetailDialog(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                article = await _articleRepository.GetArticleAsync(id);
                this.Text = $"{article.Title}";
                keywordLabel.Text = $"Từ khóa: {article.Keywords}";
                abstractRichTextBox.Text = $"{article.Abstract}";
                authorsLabel.Text = $"Tác giả: {string.Join(", ", article.Authors.Select(a => a.Name))}";
                submissionDateLabel.Text = $"{article.SubmissionDate.ToString("dd/MM/yyyy")}";
                submissionAtLabel.Text = $"Nơi công bố: {article.SubmisstionAt}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
