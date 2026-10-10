#nullable disable
namespace Bai5_1
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
            lblTitle = new System.Windows.Forms.Label();
            grpPersonal = new System.Windows.Forms.GroupBox();
            lblUser = new System.Windows.Forms.Label();
            txtUser = new System.Windows.Forms.TextBox();
            lblPass = new System.Windows.Forms.Label();
            txtPass = new System.Windows.Forms.TextBox();
            lblConfirm = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            grpExtra = new System.Windows.Forms.GroupBox();
            lblBirth = new System.Windows.Forms.Label();
            dtpBirth = new System.Windows.Forms.DateTimePicker();
            lblGender = new System.Windows.Forms.Label();
            rdoNam = new System.Windows.Forms.RadioButton();
            rdoNu = new System.Windows.Forms.RadioButton();
            chkTerms = new System.Windows.Forms.CheckBox();
            btnRegister = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            epCheck = new System.Windows.Forms.ErrorProvider(components);
            grpPersonal.SuspendLayout();
            grpExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(420, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // grpPersonal
            //
            grpPersonal.Controls.Add(lblUser);
            grpPersonal.Controls.Add(txtUser);
            grpPersonal.Controls.Add(lblPass);
            grpPersonal.Controls.Add(txtPass);
            grpPersonal.Controls.Add(lblConfirm);
            grpPersonal.Controls.Add(txtConfirm);
            grpPersonal.Location = new System.Drawing.Point(20, 60);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new System.Drawing.Size(400, 150);
            grpPersonal.TabIndex = 1;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Thông tin cá nhân";
            //
            // lblUser
            //
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(15, 34);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(103, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên đăng nhập:";
            //
            // txtUser
            //
            txtUser.Location = new System.Drawing.Point(175, 30);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(205, 25);
            txtUser.TabIndex = 1;
            //
            // lblPass
            //
            lblPass.AutoSize = true;
            lblPass.Location = new System.Drawing.Point(15, 74);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(66, 19);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật khẩu:";
            //
            // txtPass
            //
            txtPass.Location = new System.Drawing.Point(175, 70);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(205, 25);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new System.Drawing.Point(15, 114);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new System.Drawing.Size(134, 19);
            lblConfirm.TabIndex = 4;
            lblConfirm.Text = "Xác nhận mật khẩu:";
            //
            // txtConfirm
            //
            txtConfirm.Location = new System.Drawing.Point(175, 110);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new System.Drawing.Size(205, 25);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            //
            // grpExtra
            //
            grpExtra.Controls.Add(lblBirth);
            grpExtra.Controls.Add(dtpBirth);
            grpExtra.Controls.Add(lblGender);
            grpExtra.Controls.Add(rdoNam);
            grpExtra.Controls.Add(rdoNu);
            grpExtra.Controls.Add(chkTerms);
            grpExtra.Location = new System.Drawing.Point(20, 220);
            grpExtra.Name = "grpExtra";
            grpExtra.Size = new System.Drawing.Size(400, 140);
            grpExtra.TabIndex = 2;
            grpExtra.TabStop = false;
            grpExtra.Text = "Thông tin bổ sung";
            //
            // lblBirth
            //
            lblBirth.AutoSize = true;
            lblBirth.Location = new System.Drawing.Point(15, 33);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new System.Drawing.Size(73, 19);
            lblBirth.TabIndex = 0;
            lblBirth.Text = "Ngày sinh:";
            //
            // dtpBirth
            //
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpBirth.Location = new System.Drawing.Point(175, 29);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new System.Drawing.Size(205, 25);
            dtpBirth.TabIndex = 1;
            //
            // lblGender
            //
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(15, 70);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(67, 19);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            //
            // rdoNam
            //
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new System.Drawing.Point(175, 68);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new System.Drawing.Size(55, 23);
            rdoNam.TabIndex = 3;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            //
            // rdoNu
            //
            rdoNu.AutoSize = true;
            rdoNu.Location = new System.Drawing.Point(255, 68);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new System.Drawing.Size(46, 23);
            rdoNu.TabIndex = 4;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            //
            // chkTerms
            //
            chkTerms.AutoSize = true;
            chkTerms.Location = new System.Drawing.Point(18, 102);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new System.Drawing.Size(257, 23);
            chkTerms.TabIndex = 5;
            chkTerms.Text = "Tôi đồng ý với Điều khoản dịch vụ";
            chkTerms.UseVisualStyleBackColor = true;
            //
            // btnRegister
            //
            btnRegister.Location = new System.Drawing.Point(110, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(110, 38);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            //
            // btnReset
            //
            btnReset.Location = new System.Drawing.Point(240, 380);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(110, 38);
            btnReset.TabIndex = 4;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            //
            // epCheck
            //
            epCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;
            //
            // MainForm
            //
            AcceptButton = btnRegister;
            ClientSize = new System.Drawing.Size(440, 440);
            Controls.Add(lblTitle);
            Controls.Add(grpPersonal);
            Controls.Add(grpExtra);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng ký tài khoản";
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpExtra.ResumeLayout(false);
            grpExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}
