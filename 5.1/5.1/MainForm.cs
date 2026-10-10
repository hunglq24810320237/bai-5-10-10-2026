namespace Bai5_1;

/// <summary>
/// Bài 5.1: Form đăng ký tài khoản và bắt lỗi giao diện bằng ErrorProvider.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        dtpBirth.MaxDate = DateTime.Today;
    }

    private void BtnRegister_Click(object? sender, EventArgs e)
    {
        epCheck.Clear();
        bool valid = true;
        Control? firstError = null;

        void Fail(Control control, string message)
        {
            epCheck.SetError(control, message);
            epCheck.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            firstError ??= control;
            valid = false;
        }

        if (string.IsNullOrWhiteSpace(txtUser.Text))
            Fail(txtUser, "Tên đăng nhập không được để trống.");

        if (string.IsNullOrEmpty(txtPass.Text))
            Fail(txtPass, "Mật khẩu không được để trống.");

        if (txtConfirm.Text != txtPass.Text)
            Fail(txtConfirm, "Mật khẩu nhập lại không khớp.");

        if (CalculateAge(dtpBirth.Value) < 18)
            Fail(dtpBirth, "Bạn phải từ 18 tuổi trở lên.");

        if (!chkTerms.Checked)
            Fail(chkTerms, "Bạn phải đồng ý với Điều khoản dịch vụ.");

        if (!valid)
        {
            firstError?.Focus();
            return;
        }

        string gender = rdoNam.Checked ? "Nam" : "Nữ";
        MessageBox.Show(
            $"Đăng ký thành công!\n\nTên đăng nhập: {txtUser.Text.Trim()}\nNgày sinh: {dtpBirth.Value:dd/MM/yyyy}\nGiới tính: {gender}",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        epCheck.Clear();
        txtUser.Clear();
        txtPass.Clear();
        txtConfirm.Clear();
        dtpBirth.Value = DateTime.Today;
        rdoNam.Checked = true;
        chkTerms.Checked = false;
        txtUser.Focus();
    }

    private static int CalculateAge(DateTime birth)
    {
        var today = DateTime.Today;
        int age = today.Year - birth.Year;
        if (birth.Date > today.AddYears(-age)) age--;
        return age;
    }
}
