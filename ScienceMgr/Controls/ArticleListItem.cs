using ScienceMgr.Pages;
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

namespace ScienceMgr.Controls
{
    public partial class ArticleListItem : MetroFramework.Controls.MetroUserControl
    {
        private string authors;
        private string title;
        private string keywords;
        private int id;
        public EventHandler<int> editButtonClicked;
        public EventHandler<int> deleteButtonClicked;
        public EventHandler<int> titleLinkClicked;
        public ArticleListItem()
        {
            InitializeComponent();
        }
        public int Id { get => id; set => id = value; }
        public string Authors
        {
            get => authors;
            set
            {
                authors = value;
                authorsLabel.Text = value;
            }
        }
        public string Title
        {
            get => title; set
            {
                title = value;
                titleLink.Text = value;
            }
        }
        public string Keywords
        {
            get => keywords; set
            {
                keywords = value;
                keywordsLabel.Text = value;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButtonClicked?.Invoke(sender, id);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButtonClicked?.Invoke(sender, id);
        }

        private void titleLink_Click(object sender, EventArgs e)
        {
            titleLinkClicked?.Invoke(sender, id);
        }
    }
}
