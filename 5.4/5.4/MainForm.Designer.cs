#nullable disable
namespace Bai5_4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new System.Windows.Forms.Panel();
            lblView = new System.Windows.Forms.Label();
            cboView = new System.Windows.Forms.ComboBox();
            lblStatus = new System.Windows.Forms.Label();
            split = new System.Windows.Forms.SplitContainer();
            tvDepartments = new System.Windows.Forms.TreeView();
            imgSmall = new System.Windows.Forms.ImageList(components);
            lsvEmployees = new System.Windows.Forms.ListView();
            colId = new System.Windows.Forms.ColumnHeader();
            colName = new System.Windows.Forms.ColumnHeader();
            colPosition = new System.Windows.Forms.ColumnHeader();
            colStartDate = new System.Windows.Forms.ColumnHeader();
            imgLarge = new System.Windows.Forms.ImageList(components);
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            SuspendLayout();
            //
            // pnlTop
            //
            pnlTop.Controls.Add(lblView);
            pnlTop.Controls.Add(cboView);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(940, 50);
            pnlTop.TabIndex = 2;
            //
            // lblView
            //
            lblView.AutoSize = true;
            lblView.Location = new System.Drawing.Point(12, 15);
            lblView.Name = "lblView";
            lblView.Size = new System.Drawing.Size(86, 19);
            lblView.TabIndex = 0;
            lblView.Text = "Chế độ xem:";
            //
            // cboView
            //
            cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboView.FormattingEnabled = true;
            cboView.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile", "List" });
            cboView.Location = new System.Drawing.Point(125, 11);
            cboView.Name = "cboView";
            cboView.Size = new System.Drawing.Size(160, 25);
            cboView.TabIndex = 1;
            cboView.SelectedIndexChanged += CboView_SelectedIndexChanged;
            //
            // lblStatus
            //
            lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblStatus.Location = new System.Drawing.Point(0, 532);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            lblStatus.Size = new System.Drawing.Size(940, 28);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // split
            //
            split.Dock = System.Windows.Forms.DockStyle.Fill;
            split.Location = new System.Drawing.Point(0, 0);
            split.Name = "split";
            //
            // split.Panel1
            //
            split.Panel1.Controls.Add(tvDepartments);
            //
            // split.Panel2
            //
            split.Panel2.Controls.Add(lsvEmployees);
            split.Size = new System.Drawing.Size(940, 560);
            split.SplitterDistance = 280;
            split.TabIndex = 0;
            //
            // tvDepartments
            //
            tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            tvDepartments.HideSelection = false;
            tvDepartments.ImageList = imgSmall;
            tvDepartments.ItemHeight = 24;
            tvDepartments.Location = new System.Drawing.Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.PathSeparator = "/";
            tvDepartments.Size = new System.Drawing.Size(280, 560);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += TvDepartments_AfterSelect;
            //
            // imgSmall
            //
            imgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgSmall.ImageSize = new System.Drawing.Size(20, 20);
            imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            //
            // lsvEmployees
            //
            lsvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colId, colName, colPosition, colStartDate });
            lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imgLarge;
            lsvEmployees.Location = new System.Drawing.Point(0, 0);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new System.Drawing.Size(656, 560);
            lsvEmployees.SmallImageList = imgSmall;
            lsvEmployees.TabIndex = 0;
            lsvEmployees.TileSize = new System.Drawing.Size(230, 52);
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = System.Windows.Forms.View.Details;
            //
            // colId
            //
            colId.Text = "Mã NV";
            colId.Width = 90;
            //
            // colName
            //
            colName.Text = "Họ Tên";
            colName.Width = 190;
            //
            // colPosition
            //
            colPosition.Text = "Chức vụ";
            colPosition.Width = 200;
            //
            // colStartDate
            //
            colStartDate.Text = "Ngày vào làm";
            colStartDate.Width = 120;
            //
            // imgLarge
            //
            imgLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgLarge.ImageSize = new System.Drawing.Size(40, 40);
            imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            //
            // MainForm
            //
            ClientSize = new System.Drawing.Size(940, 560);
            Controls.Add(split);
            Controls.Add(lblStatus);
            Controls.Add(pnlTop);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            MinimumSize = new System.Drawing.Size(760, 420);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Quản lý nhân sự";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ImageList imgSmall;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ImageList imgLarge;
    }
}
