using System.Globalization;

namespace Bai5_2;

/// <summary>
/// Bài 5.2: Bảng tính tiền dịch vụ và chiết khấu đơn hàng (ListBox và ComboBox).
/// </summary>
public partial class MainForm : Form
{
    public static readonly CultureInfo Vn = new("vi-VN");

    private readonly Dictionary<string, List<ServiceItem>> catalog = new()
    {
        ["Khám bệnh"] = new()
        {
            new("Khám tổng quát", 150000),
            new("Khám nội khoa", 120000),
            new("Khám nhi", 100000),
            new("Khám tai mũi họng", 130000),
            new("Khám mắt", 140000),
        },
        ["Xét nghiệm"] = new()
        {
            new("Xét nghiệm máu", 200000),
            new("Xét nghiệm nước tiểu", 80000),
            new("Xét nghiệm đường huyết", 60000),
            new("Xét nghiệm mỡ máu", 180000),
        },
        ["Chụp X-Quang"] = new()
        {
            new("X-Quang phổi", 250000),
            new("X-Quang cột sống", 300000),
            new("X-Quang xương khớp", 270000),
        },
        ["Vắc-xin"] = new()
        {
            new("Vắc-xin cúm mùa", 350000),
            new("Vắc-xin viêm gan B", 280000),
            new("Vắc-xin uốn ván", 150000),
            new("Vắc-xin HPV", 1800000),
        },
    };

    /// <summary>Mã giảm giá và tỷ lệ chiết khấu tương ứng (%).</summary>
    private readonly Dictionary<string, int> coupons = new(StringComparer.OrdinalIgnoreCase)
    {
        ["GIAM10"] = 10,
        ["GIAM20"] = 20,
    };

    private int couponRate;

    public MainForm()
    {
        InitializeComponent();

        cboCategory.Items.AddRange(catalog.Keys.ToArray<object>());
        cboCategory.SelectedIndex = 0;
        Recalculate();
    }

    private void LstAvailableServices_DoubleClick(object? sender, EventArgs e) => SelectCurrent();

    private void LstSelectedServices_DoubleClick(object? sender, EventArgs e) => RemoveCurrent();

    private void BtnSelect_Click(object? sender, EventArgs e) => SelectCurrent();

    private void BtnRemove_Click(object? sender, EventArgs e) => RemoveCurrent();

    private void BtnClearAll_Click(object? sender, EventArgs e)
    {
        lstSelectedServices.Items.Clear();
        Recalculate();
    }

    private void CboCategory_SelectedIndexChanged(object? sender, EventArgs e)
    {
        lstAvailableServices.Items.Clear();
        if (cboCategory.SelectedItem is string key && catalog.TryGetValue(key, out var services))
            lstAvailableServices.Items.AddRange(services.ToArray<object>());
    }

    private void SelectCurrent()
    {
        if (lstAvailableServices.SelectedItem is not ServiceItem item) return;
        lstSelectedServices.Items.Add(item);
        Recalculate();
    }

    private void RemoveCurrent()
    {
        int index = lstSelectedServices.SelectedIndex;
        if (index < 0) return;
        lstSelectedServices.Items.RemoveAt(index);
        Recalculate();
    }

    private void BtnApplyCoupon_Click(object? sender, EventArgs e)
    {
        string code = txtCoupon.Text.Trim();
        if (code.Length == 0)
        {
            couponRate = 0;
            lblCouponInfo.ForeColor = Color.DimGray;
            lblCouponInfo.Text = "Đã bỏ mã giảm giá.";
        }
        else if (coupons.TryGetValue(code, out int rate))
        {
            couponRate = rate;
            lblCouponInfo.ForeColor = Color.SeaGreen;
            lblCouponInfo.Text = $"Áp dụng thành công: giảm {rate}%.";
        }
        else
        {
            couponRate = 0;
            lblCouponInfo.ForeColor = Color.Firebrick;
            lblCouponInfo.Text = "Mã giảm giá không hợp lệ.";
        }
        Recalculate();
    }

    /// <summary>Tính lại tổng tiền mỗi khi danh sách dịch vụ đã chọn hoặc mã giảm giá thay đổi.</summary>
    private void Recalculate()
    {
        decimal subtotal = lstSelectedServices.Items.Cast<ServiceItem>().Sum(s => s.Price);

        int autoRate = subtotal >= 2_000_000 ? 15 : subtotal >= 1_000_000 ? 10 : subtotal >= 500_000 ? 5 : 0;
        int rate = Math.Max(autoRate, couponRate);
        decimal total = subtotal - subtotal * rate / 100;

        txtSubtotal.Text = $"{subtotal.ToString("N0", Vn)} đ";
        txtDiscountRate.Text = $"{rate}%";
        txtTotal.Text = $"{total.ToString("N0", Vn)} đ";
    }
}
