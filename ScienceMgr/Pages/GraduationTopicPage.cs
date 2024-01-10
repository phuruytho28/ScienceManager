using ScienceMgr.Forms.GraduationTopic;
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
    public partial class GraduationTopicPage : Page
    {
        private readonly IGraduationTopicRepository _repository = new GraduationTopicRepository();
        private GraduationTopic selectedTopic;
        public GraduationTopicPage()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                graduationTopicGrid.SelectionChanged += graduationTopicGrid_SelectionChanged;
                await LoadData();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void graduationTopicGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (graduationTopicGrid.SelectedRows.Count > 0)
            {
                var row = graduationTopicGrid.SelectedRows[0];
                var id = int.Parse(row.Cells["Id"].Value.ToString());
                selectedTopic = await _repository.GetGraduationTopic(id);
            }
        }

        private async Task LoadData()
        {
            Cursor = Cursors.WaitCursor;
            var topics = await _repository.GetGraduationTopics();
            var displayedTopics = topics.Select(x => new
            {
                Id = x.Id,
                Title = x.Topic,
                StudentName = x.Student.Name,
                TeacherName = x.Supervisor.Name,
                Grade = x.Grade,
                Description = x.Description,
            }).ToList();
            graduationTopicGrid.DataSource = displayedTopics;
            graduationTopicGrid.Columns["Id"].HeaderText = "Mã số";
            graduationTopicGrid.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            graduationTopicGrid.Columns["Id"].Visible = false;
            graduationTopicGrid.Columns["Title"].HeaderText = "Tiêu đề";
            graduationTopicGrid.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            graduationTopicGrid.Columns["Description"].HeaderText = "Mô tả";
            graduationTopicGrid.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            graduationTopicGrid.Columns["Description"].Visible = false;
            graduationTopicGrid.Columns["StudentName"].HeaderText = "Sinh viên bảo vệ";
            graduationTopicGrid.Columns["StudentName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            graduationTopicGrid.Columns["TeacherName"].HeaderText = "Giảng viên hướng dẫn";
            graduationTopicGrid.Columns["TeacherName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            graduationTopicGrid.Columns["Grade"].HeaderText = "Điểm";
            graduationTopicGrid.Columns["Grade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            Cursor = Cursors.Default;
        }

        private async void addNewTile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new AddGraduationTopicDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        graduationTopicGrid.DataSource = null;
                        graduationTopicGrid.Rows.Clear();
                        await LoadData();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void editTile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new EditGraduationTopicDialog(selectedTopic))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        graduationTopicGrid.DataSource = null;
                        graduationTopicGrid.Rows.Clear();
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
                if (selectedTopic == null)
                    return;
                string message = $"Bạn có chắc chắn muốn xóa đề tài '{selectedTopic.Topic}' có id '{selectedTopic.Id}'?";
                if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _repository.DeleteGraduationTopic(selectedTopic.Id);
                    graduationTopicGrid.DataSource = null;
                    graduationTopicGrid.Rows.Clear();
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
