using ScienceMgr.DbContext;
using ScienceMgr.Pages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScienceMgr
{
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public void ShowPage<TPage>() where TPage : Page
        {
            try
            {
                var page = Activator.CreateInstance<TPage>();
                page.Dock = DockStyle.Fill;
                rightPanel.Controls.Clear();
                rightPanel.Controls.Add(page);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        public HomeForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            ShowPage<HomePage>();

            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                var dbContext = new ApplicationDbContext();
                dbContext.Database.CreateIfNotExists();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        private void homeLink_Click(object sender, EventArgs e)
        {
            ShowPage<HomePage>();
        }
    }
}
