#nullable disable
namespace Bai5_3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitle = new System.Windows.Forms.Label();
            grpInfo = new System.Windows.Forms.GroupBox();
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblPrice = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            lblQuantity = new System.Windows.Forms.Label();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            lblCategory = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            grpActions = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvProducts = new System.Windows.Forms.DataGridView();
            colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblStatus = new System.Windows.Forms.Label();
            bindingSource = new System.Windows.Forms.BindingSource(components);
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(10, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(840, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH SÁCH SẢN PHẨM";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // grpInfo
            //
            grpInfo.Controls.Add(lblId);
            grpInfo.Controls.Add(txtId);
            grpInfo.Controls.Add(lblName);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(lblPrice);
            grpInfo.Controls.Add(txtPrice);
            grpInfo.Controls.Add(lblQuantity);
            grpInfo.Controls.Add(nudQuantity);
            grpInfo.Controls.Add(lblCategory);
            grpInfo.Controls.Add(cboCategory);
            grpInfo.Location = new System.Drawing.Point(20, 55);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new System.Drawing.Size(520, 190);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sản phẩm";
            //
            // lblId
            //
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(15, 34);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(47, 19);
            lblId.TabIndex = 0;
            lblId.Text = "Mã SP:";
            //
            // txtId
            //
            txtId.Location = new System.Drawing.Point(110, 30);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(395, 25);
            txtId.TabIndex = 1;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(15, 69);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(53, 19);
            lblName.TabIndex = 2;
            lblName.Text = "Tên SP:";
            //
            // txtName
            //
            txtName.Location = new System.Drawing.Point(110, 65);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(395, 25);
            txtName.TabIndex = 3;
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(15, 104);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(57, 19);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Đơn giá:";
            //
            // txtPrice
            //
            txtPrice.Location = new System.Drawing.Point(110, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(395, 25);
            txtPrice.TabIndex = 5;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(15, 139);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(66, 19);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng:";
            //
            // nudQuantity
            //
            nudQuantity.Location = new System.Drawing.Point(110, 135);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(130, 25);
            nudQuantity.TabIndex = 7;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(250, 139);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(70, 19);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục:";
            //
            // cboCategory
            //
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Phụ kiện", "Thiết bị hiển thị", "Lưu trữ", "Linh kiện", "Khác" });
            cboCategory.Location = new System.Drawing.Point(345, 135);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(160, 25);
            cboCategory.TabIndex = 9;
            //
            // grpActions
            //
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(btnEdit);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(lblSearch);
            grpActions.Controls.Add(txtSearch);
            grpActions.Controls.Add(btnSearch);
            grpActions.Location = new System.Drawing.Point(560, 55);
            grpActions.Name = "grpActions";
            grpActions.Size = new System.Drawing.Size(280, 190);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Chức năng";
            //
            // btnAdd
            //
            btnAdd.Location = new System.Drawing.Point(15, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(120, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            //
            // btnEdit
            //
            btnEdit.Location = new System.Drawing.Point(145, 28);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(120, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new System.Drawing.Point(15, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Location = new System.Drawing.Point(15, 128);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(111, 19);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm theo tên SP:";
            //
            // txtSearch
            //
            txtSearch.Location = new System.Drawing.Point(15, 152);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(150, 25);
            txtSearch.TabIndex = 4;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            //
            // btnSearch
            //
            btnSearch.Location = new System.Drawing.Point(172, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(95, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            //
            // dgvProducts
            //
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colProductId, colProductName, colUnitPrice, colQuantity, colCategory });
            dgvProducts.Location = new System.Drawing.Point(20, 258);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(820, 296);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += DgvProducts_CellClick;
            dgvProducts.CurrentCellChanged += DgvProducts_CurrentCellChanged;
            //
            // colProductId
            //
            colProductId.DataPropertyName = "ProductId";
            colProductId.FillWeight = 12F;
            colProductId.HeaderText = "Mã SP";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            //
            // colProductName
            //
            colProductName.DataPropertyName = "ProductName";
            colProductName.FillWeight = 34F;
            colProductName.HeaderText = "Tên SP";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            //
            // colUnitPrice
            //
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.FillWeight = 20F;
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            //
            // colQuantity
            //
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 12F;
            colQuantity.HeaderText = "Số lượng";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            //
            // colCategory
            //
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            colCategory.DefaultCellStyle = dataGridViewCellStyle3;
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 22F;
            colCategory.HeaderText = "Danh mục";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = System.Drawing.Color.DimGray;
            lblStatus.Location = new System.Drawing.Point(20, 564);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(0, 19);
            lblStatus.TabIndex = 4;
            //
            // MainForm
            //
            ClientSize = new System.Drawing.Size(860, 600);
            Controls.Add(lblTitle);
            Controls.Add(grpInfo);
            Controls.Add(grpActions);
            Controls.Add(dgvProducts);
            Controls.Add(lblStatus);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.3 - Quản lý sản phẩm";
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}
