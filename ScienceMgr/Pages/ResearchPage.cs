using ScienceMgr.Forms.Research;
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

namespace ScienceMgr.Pages
{
    public partial class ResearchPage : Page
    {
        private readonly IResearchRepository _repository = new ResearchRepository();
        private Research selectedResearch;


        public ResearchPage()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                researchGrid.SelectionChanged += researchGrid_SelectionChanged;
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void researchGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (researchGrid.SelectedRows.Count > 0)
            {
                var selectedRow = researchGrid.SelectedRows[0];
                var id = (int)selectedRow.Cells["Id"].Value;
                selectedResearch = await _repository.GetResearchAsync(id);
            }

        }

        private async Task LoadData()
        {
            Cursor = Cursors.WaitCursor;
            var researches = await _repository.GetResearchesAsync();
            var displayedResearches = researches.Select(x => new
            {
                Id = x.Id,
                Title = x.Title,
                StartDate = x.StartDate.ToString("dd/MM/yyyy"),
                EndDate = x.EndDate.ToString("dd/MM/yyyy"),
                Keywords = x.Keywords,
                Description = x.Description,
                
            }).ToList();
            researchGrid.DataSource = displayedResearches;
            researchGrid.Columns["Id"].Visible = false;
            researchGrid.Columns["Description"].Visible = false;
            researchGrid.Columns["Title"].HeaderText = "Tên đề tài";
            researchGrid.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            researchGrid.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            researchGrid.Columns["Keywords"].HeaderText = "Từ khóa";
            researchGrid.Columns["Description"].HeaderText = "Mô tả";
            researchGrid.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            researchGrid.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            researchGrid.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            researchGrid.Columns["Keywords"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Cursor = Cursors.Default;

        }

        private async void addNewTile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new AddResearchDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        researchGrid.DataSource = null;
                        await LoadData();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void editTile_Click(object sender, EventArgs e)
        {

            try
            {
                using (var dialog = new EditResearchDialog(selectedResearch.Id))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        researchGrid.DataSource = null;
                        await LoadData();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void deleteTile_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedResearch == null)
                    return;
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa đề tài \"{selectedResearch.Title}\"?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _repository.DeleteResearchAsync(selectedResearch.Id);
                    researchGrid.DataSource = null;
                    researchGrid.Rows.Clear();
                    await LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
