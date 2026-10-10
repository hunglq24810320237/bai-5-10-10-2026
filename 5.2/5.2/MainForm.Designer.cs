#nullable disable
namespace Bai5_2
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
            lblTitle = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            lblAvail = new System.Windows.Forms.Label();
            lstAvailableServices = new System.Windows.Forms.ListBox();
            lblChosen = new System.Windows.Forms.Label();
            lstSelectedServices = new System.Windows.Forms.ListBox();
            btnSelect = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            btnClearAll = new System.Windows.Forms.Button();
            grpPay = new System.Windows.Forms.GroupBox();
            lblCoupon = new System.Windows.Forms.Label();
            txtCoupon = new System.Windows.Forms.TextBox();
            btnApplyCoupon = new System.Windows.Forms.Button();
            lblCouponInfo = new System.Windows.Forms.Label();
            lblSubtotal = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            lblRate = new System.Windows.Forms.Label();
            txtDiscountRate = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            lblRule = new System.Windows.Forms.Label();
            grpPay.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(10, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(800, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(20, 62);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(88, 19);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Loại dịch vụ:";
            //
            // cboCategory
            //
            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(120, 58);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(240, 25);
            cboCategory.TabIndex = 2;
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            //
            // lblAvail
            //
            lblAvail.AutoSize = true;
            lblAvail.Location = new System.Drawing.Point(20, 98);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new System.Drawing.Size(103, 19);
            lblAvail.TabIndex = 3;
            lblAvail.Text = "Dịch vụ có sẵn";
            //
            // lstAvailableServices
            //
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 17;
            lstAvailableServices.Location = new System.Drawing.Point(20, 124);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new System.Drawing.Size(340, 230);
            lstAvailableServices.TabIndex = 4;
            lstAvailableServices.DoubleClick += LstAvailableServices_DoubleClick;
            //
            // lblChosen
            //
            lblChosen.AutoSize = true;
            lblChosen.Location = new System.Drawing.Point(460, 98);
            lblChosen.Name = "lblChosen";
            lblChosen.Size = new System.Drawing.Size(105, 19);
            lblChosen.TabIndex = 5;
            lblChosen.Text = "Dịch vụ đã chọn";
            //
            // lstSelectedServices
            //
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 17;
            lstSelectedServices.Location = new System.Drawing.Point(460, 124);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new System.Drawing.Size(340, 230);
            lstSelectedServices.TabIndex = 6;
            lstSelectedServices.DoubleClick += LstSelectedServices_DoubleClick;
            //
            // btnSelect
            //
            btnSelect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSelect.Location = new System.Drawing.Point(380, 150);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(60, 36);
            btnSelect.TabIndex = 7;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += BtnSelect_Click;
            //
            // btnRemove
            //
            btnRemove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRemove.Location = new System.Drawing.Point(380, 200);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(60, 36);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            //
            // btnClearAll
            //
            btnClearAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnClearAll.Location = new System.Drawing.Point(380, 250);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new System.Drawing.Size(60, 36);
            btnClearAll.TabIndex = 9;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += BtnClearAll_Click;
            //
            // grpPay
            //
            grpPay.Controls.Add(lblCoupon);
            grpPay.Controls.Add(txtCoupon);
            grpPay.Controls.Add(btnApplyCoupon);
            grpPay.Controls.Add(lblCouponInfo);
            grpPay.Controls.Add(lblSubtotal);
            grpPay.Controls.Add(txtSubtotal);
            grpPay.Controls.Add(lblRate);
            grpPay.Controls.Add(txtDiscountRate);
            grpPay.Controls.Add(lblTotal);
            grpPay.Controls.Add(txtTotal);
            grpPay.Controls.Add(lblRule);
            grpPay.Location = new System.Drawing.Point(20, 370);
            grpPay.Name = "grpPay";
            grpPay.Size = new System.Drawing.Size(780, 170);
            grpPay.TabIndex = 10;
            grpPay.TabStop = false;
            grpPay.Text = "Thanh toán";
            //
            // lblCoupon
            //
            lblCoupon.AutoSize = true;
            lblCoupon.Location = new System.Drawing.Point(15, 34);
            lblCoupon.Name = "lblCoupon";
            lblCoupon.Size = new System.Drawing.Size(88, 19);
            lblCoupon.TabIndex = 0;
            lblCoupon.Text = "Mã giảm giá:";
            //
            // txtCoupon
            //
            txtCoupon.Location = new System.Drawing.Point(150, 30);
            txtCoupon.Name = "txtCoupon";
            txtCoupon.Size = new System.Drawing.Size(150, 25);
            txtCoupon.TabIndex = 1;
            //
            // btnApplyCoupon
            //
            btnApplyCoupon.Location = new System.Drawing.Point(310, 28);
            btnApplyCoupon.Name = "btnApplyCoupon";
            btnApplyCoupon.Size = new System.Drawing.Size(90, 30);
            btnApplyCoupon.TabIndex = 2;
            btnApplyCoupon.Text = "Áp dụng";
            btnApplyCoupon.UseVisualStyleBackColor = true;
            btnApplyCoupon.Click += BtnApplyCoupon_Click;
            //
            // lblCouponInfo
            //
            lblCouponInfo.AutoSize = true;
            lblCouponInfo.ForeColor = System.Drawing.Color.DimGray;
            lblCouponInfo.Location = new System.Drawing.Point(410, 34);
            lblCouponInfo.Name = "lblCouponInfo";
            lblCouponInfo.Size = new System.Drawing.Size(165, 19);
            lblCouponInfo.TabIndex = 3;
            lblCouponInfo.Text = "Thử GIAM10 hoặc GIAM20";
            //
            // lblSubtotal
            //
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new System.Drawing.Point(15, 74);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(141, 19);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "Tổng tiền chưa giảm:";
            //
            // txtSubtotal
            //
            txtSubtotal.Location = new System.Drawing.Point(190, 70);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(210, 25);
            txtSubtotal.TabIndex = 5;
            txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblRate
            //
            lblRate.AutoSize = true;
            lblRate.Location = new System.Drawing.Point(15, 104);
            lblRate.Name = "lblRate";
            lblRate.Size = new System.Drawing.Size(142, 19);
            lblRate.TabIndex = 6;
            lblRate.Text = "Tỷ lệ chiết khấu (%):";
            //
            // txtDiscountRate
            //
            txtDiscountRate.Location = new System.Drawing.Point(190, 100);
            txtDiscountRate.Name = "txtDiscountRate";
            txtDiscountRate.ReadOnly = true;
            txtDiscountRate.Size = new System.Drawing.Size(210, 25);
            txtDiscountRate.TabIndex = 7;
            txtDiscountRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(15, 134);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(158, 19);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Thành tiền thanh toán:";
            //
            // txtTotal
            //
            txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            txtTotal.ForeColor = System.Drawing.Color.Firebrick;
            txtTotal.Location = new System.Drawing.Point(190, 130);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(210, 27);
            txtTotal.TabIndex = 9;
            txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblRule
            //
            lblRule.ForeColor = System.Drawing.Color.DimGray;
            lblRule.Location = new System.Drawing.Point(440, 70);
            lblRule.Name = "lblRule";
            lblRule.Size = new System.Drawing.Size(325, 90);
            lblRule.TabIndex = 10;
            lblRule.Text = "Tự động giảm 5% từ 500.000 đ, 10% từ 1.000.000 đ, 15% từ 2.000.000 đ. Mã giảm giá không cộng dồn, lấy mức cao hơn.";
            //
            // MainForm
            //
            ClientSize = new System.Drawing.Size(820, 560);
            Controls.Add(lblTitle);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvail);
            Controls.Add(lstAvailableServices);
            Controls.Add(lblChosen);
            Controls.Add(lstSelectedServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(grpPay);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Tính tiền dịch vụ";
            grpPay.ResumeLayout(false);
            grpPay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.Label lblCouponInfo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblRule;
    }
}
