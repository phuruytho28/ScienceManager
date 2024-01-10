namespace ScienceMgr.Pages
{
    partial class ResearchPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteTile = new MetroFramework.Controls.MetroTile();
            this.editTile = new MetroFramework.Controls.MetroTile();
            this.addNewTile = new MetroFramework.Controls.MetroTile();
            this.panel3 = new System.Windows.Forms.Panel();
            this.researchGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nghiên cứu khoa học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteTile);
            this.panel2.Controls.Add(this.editTile);
            this.panel2.Controls.Add(this.addNewTile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(933, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 687);
            this.panel2.TabIndex = 1;
            // 
            // deleteTile
            // 
            this.deleteTile.ActiveControl = null;
            this.deleteTile.Location = new System.Drawing.Point(58, 204);
            this.deleteTile.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.deleteTile.Name = "deleteTile";
            this.deleteTile.Size = new System.Drawing.Size(116, 78);
            this.deleteTile.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteTile.TabIndex = 10;
            this.deleteTile.Text = "Xóa";
            this.deleteTile.TileImage = global::ScienceMgr.Properties.Resources._32_delete;
            this.deleteTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.deleteTile.UseSelectable = true;
            this.deleteTile.UseTileImage = true;
            this.deleteTile.Click += new System.EventHandler(this.deleteTile_Click);
            // 
            // editTile
            // 
            this.editTile.ActiveControl = null;
            this.editTile.Location = new System.Drawing.Point(58, 102);
            this.editTile.Margin = new System.Windows.Forms.Padding(13, 12, 40, 12);
            this.editTile.Name = "editTile";
            this.editTile.Size = new System.Drawing.Size(116, 78);
            this.editTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.editTile.TabIndex = 9;
            this.editTile.Text = "Chỉnh sửa";
            this.editTile.TileImage = global::ScienceMgr.Properties.Resources._32_edit;
            this.editTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.editTile.UseSelectable = true;
            this.editTile.UseTileImage = true;
            this.editTile.Click += new System.EventHandler(this.editTile_Click);
            // 
            // addNewTile
            // 
            this.addNewTile.ActiveControl = null;
            this.addNewTile.Location = new System.Drawing.Point(58, 0);
            this.addNewTile.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.addNewTile.Name = "addNewTile";
            this.addNewTile.Size = new System.Drawing.Size(116, 78);
            this.addNewTile.Style = MetroFramework.MetroColorStyle.Green;
            this.addNewTile.TabIndex = 8;
            this.addNewTile.Text = "Thêm mới";
            this.addNewTile.TileImage = global::ScienceMgr.Properties.Resources._32_add;
            this.addNewTile.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addNewTile.UseSelectable = true;
            this.addNewTile.UseTileImage = true;
            this.addNewTile.Click += new System.EventHandler(this.addNewTile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.researchGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 687);
            this.panel3.TabIndex = 2;
            // 
            // researchGrid
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.researchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.researchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.researchGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.researchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.researchGrid.Location = new System.Drawing.Point(0, 0);
            this.researchGrid.Name = "researchGrid";
            this.researchGrid.RowHeadersWidth = 51;
            this.researchGrid.RowTemplate.Height = 24;
            this.researchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.researchGrid.Size = new System.Drawing.Size(933, 687);
            this.researchGrid.TabIndex = 4;
            // 
            // ResearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResearchPage";
            this.Size = new System.Drawing.Size(1156, 782);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.researchGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView researchGrid;
        private MetroFramework.Controls.MetroTile deleteTile;
        private MetroFramework.Controls.MetroTile editTile;
        private MetroFramework.Controls.MetroTile addNewTile;
        private System.Windows.Forms.Label label1;
    }
}
