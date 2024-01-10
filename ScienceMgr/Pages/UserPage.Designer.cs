namespace ScienceMgr.Pages
{
    partial class UserPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editTile = new MetroFramework.Controls.MetroTile();
            this.deleteTile = new MetroFramework.Controls.MetroTile();
            this.addNewTile = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editTile);
            this.panel1.Controls.Add(this.deleteTile);
            this.panel1.Controls.Add(this.addNewTile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 100);
            this.panel1.TabIndex = 1;
            // 
            // editTile
            // 
            this.editTile.ActiveControl = null;
            this.editTile.Location = new System.Drawing.Point(865, 24);
            this.editTile.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.editTile.Name = "editTile";
            this.editTile.Size = new System.Drawing.Size(87, 63);
            this.editTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.editTile.TabIndex = 2;
            this.editTile.Text = "Chỉnh sửa";
            this.editTile.TileImage = global::ScienceMgr.Properties.Resources._32_edit;
            this.editTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.editTile.UseSelectable = true;
            this.editTile.UseTileImage = true;
            this.editTile.Click += new System.EventHandler(this.editTile_Click);
            // 
            // deleteTile
            // 
            this.deleteTile.ActiveControl = null;
            this.deleteTile.Location = new System.Drawing.Point(956, 24);
            this.deleteTile.Margin = new System.Windows.Forms.Padding(10);
            this.deleteTile.Name = "deleteTile";
            this.deleteTile.Size = new System.Drawing.Size(87, 63);
            this.deleteTile.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteTile.TabIndex = 1;
            this.deleteTile.Text = "Xóa";
            this.deleteTile.TileImage = global::ScienceMgr.Properties.Resources._32_delete;
            this.deleteTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.deleteTile.UseSelectable = true;
            this.deleteTile.UseTileImage = true;
            this.deleteTile.Click += new System.EventHandler(this.deleteTile_Click);
            // 
            // addNewTile
            // 
            this.addNewTile.ActiveControl = null;
            this.addNewTile.Location = new System.Drawing.Point(775, 24);
            this.addNewTile.Margin = new System.Windows.Forms.Padding(10);
            this.addNewTile.Name = "addNewTile";
            this.addNewTile.Size = new System.Drawing.Size(87, 63);
            this.addNewTile.Style = MetroFramework.MetroColorStyle.Green;
            this.addNewTile.TabIndex = 0;
            this.addNewTile.Text = "Thêm mới";
            this.addNewTile.TileImage = global::ScienceMgr.Properties.Resources._32_add;
            this.addNewTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addNewTile.UseSelectable = true;
            this.addNewTile.UseTileImage = true;
            this.addNewTile.Click += new System.EventHandler(this.addNewTile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 16);
            this.panel2.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1044, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // userGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGrid.Location = new System.Drawing.Point(0, 100);
            this.userGrid.Name = "userGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.userGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.userGrid.RowTemplate.Height = 26;
            this.userGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGrid.Size = new System.Drawing.Size(1044, 508);
            this.userGrid.TabIndex = 2;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(1044, 624);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView userGrid;
        private MetroFramework.Controls.MetroTile editTile;
        private MetroFramework.Controls.MetroTile deleteTile;
        private MetroFramework.Controls.MetroTile addNewTile;
    }
}
