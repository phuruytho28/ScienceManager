using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Pages
{
    public partial class HomePage : Page
    {
        private HomeForm homeForm;
        public HomePage()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            homeForm = this.ParentForm as HomeForm;
        }

        private void userTile_Click(object sender, EventArgs e)
        {
            homeForm.ShowPage<UserPage>();
        }

        private void articleTile_Click(object sender, EventArgs e)
        {
            homeForm.ShowPage<ArticlePage>();
        }

        private void researchTile_Click(object sender, EventArgs e)
        {
            homeForm.ShowPage<ResearchPage>();
        }

        private void graduationTopicTile_Click(object sender, EventArgs e)
        {
            homeForm.ShowPage<GraduationTopicPage>();
        }
    }
}
