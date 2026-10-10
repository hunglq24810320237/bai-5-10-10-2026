using System.Globalization;

namespace Bai5_3;

/// <summary>
/// Bài 5.3: Quản lý danh sách sản phẩm trong bộ nhớ (List&lt;Product&gt; + BindingSource + DataGridView).
/// </summary>
public partial class MainForm : Form
{
    private static readonly CultureInfo Vn = new("vi-VN");

    private readonly List<Product> products = new()
    {
        new() { ProductId = "SP001", ProductName = "Bàn phím cơ", UnitPrice = 850000, Quantity = 15, Category = "Phụ kiện" },
        new() { ProductId = "SP002", ProductName = "Chuột không dây", UnitPrice = 320000, Quantity = 40, Category = "Phụ kiện" },
        new() { ProductId = "SP003", ProductName = "Màn hình 24 inch", UnitPrice = 3200000, Quantity = 8, Category = "Thiết bị hiển thị" },
        new() { ProductId = "SP004", ProductName = "Ổ cứng SSD 512GB", UnitPrice = 1250000, Quantity = 22, Category = "Lưu trữ" },
    };

    private string currentFilter = "";

    public MainForm()
    {
        InitializeComponent();

        colUnitPrice.DefaultCellStyle.FormatProvider = Vn;
        cboCategory.SelectedIndex = 0;
        dgvProducts.DataSource = bindingSource;

        RefreshGrid();
        ActiveControl = dgvProducts;
    }

    private void BtnSearch_Click(object? sender, EventArgs e)
    {
        currentFilter = txtSearch.Text.Trim();
        RefreshGrid();
    }

    private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            btnSearch.PerformClick();
        }
    }

    private void DgvProducts_CurrentCellChanged(object? sender, EventArgs e) => PushRowToInputs();

    /// <summary>Đổ lại dữ liệu từ List&lt;Product&gt; (có áp dụng bộ lọc tìm kiếm) lên DataGridView.</summary>
    private void RefreshGrid()
    {
        IEnumerable<Product> view = products;
        if (currentFilter.Length > 0)
        {
            view = products.Where(p =>
                p.ProductName.Contains(currentFilter, StringComparison.CurrentCultureIgnoreCase));
        }

        var list = view.ToList();
        bindingSource.DataSource = list;
        bindingSource.ResetBindings(false);
        lblStatus.Text = currentFilter.Length > 0
            ? $"Tìm thấy {list.Count} sản phẩm với từ khóa \"{currentFilter}\"."
            : $"Tổng số sản phẩm: {list.Count}";
    }

    private Product? SelectedProduct()
        => dgvProducts.CurrentRow?.DataBoundItem as Product;

    private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e) => PushRowToInputs();

    /// <summary>Đẩy dữ liệu dòng đang chọn ngược lên các ô nhập liệu.</summary>
    private void PushRowToInputs()
    {
        var p = SelectedProduct();
        if (p == null) return;
        txtId.Text = p.ProductId;
        txtName.Text = p.ProductName;
        txtPrice.Text = p.UnitPrice.ToString("0.##", CultureInfo.InvariantCulture);
        nudQuantity.Value = Math.Min(nudQuantity.Maximum, Math.Max(nudQuantity.Minimum, p.Quantity));
        if (!cboCategory.Items.Contains(p.Category)) cboCategory.Items.Add(p.Category);
        cboCategory.SelectedItem = p.Category;
    }

    /// <summary>Đọc và kiểm tra dữ liệu nhập, trả về null nếu không hợp lệ.</summary>
    private Product? ReadInputs()
    {
        string id = txtId.Text.Trim();
        string name = txtName.Text.Trim();

        if (id.Length == 0 || name.Length == 0)
        {
            Warn("Mã SP và Tên SP không được để trống.");
            return null;
        }

        string priceText = txtPrice.Text.Trim().Replace(",", "").Replace(" ", "");
        if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price) || price < 0)
        {
            Warn("Đơn giá phải là số không âm.");
            return null;
        }

        return new Product
        {
            ProductId = id,
            ProductName = name,
            UnitPrice = price,
            Quantity = (int)nudQuantity.Value,
            Category = cboCategory.Text,
        };
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        var p = ReadInputs();
        if (p == null) return;

        if (products.Any(x => x.ProductId.Equals(p.ProductId, StringComparison.OrdinalIgnoreCase)))
        {
            Warn($"Mã SP \"{p.ProductId}\" đã tồn tại.");
            return;
        }

        products.Add(p);
        RefreshGrid();
        SelectRowById(p.ProductId);
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        var current = SelectedProduct();
        if (current == null)
        {
            Warn("Hãy chọn một sản phẩm trong bảng để sửa.");
            return;
        }

        var input = ReadInputs();
        if (input == null) return;

        bool duplicate = products.Any(x =>
            !ReferenceEquals(x, current) &&
            x.ProductId.Equals(input.ProductId, StringComparison.OrdinalIgnoreCase));
        if (duplicate)
        {
            Warn($"Mã SP \"{input.ProductId}\" đã tồn tại.");
            return;
        }

        current.ProductId = input.ProductId;
        current.ProductName = input.ProductName;
        current.UnitPrice = input.UnitPrice;
        current.Quantity = input.Quantity;
        current.Category = input.Category;
        RefreshGrid();
        SelectRowById(current.ProductId);
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        var current = SelectedProduct();
        if (current == null)
        {
            Warn("Hãy chọn một sản phẩm trong bảng để xóa.");
            return;
        }

        var answer = MessageBox.Show(
            $"Bạn có chắc muốn xóa sản phẩm \"{current.ProductName}\" không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (answer != DialogResult.Yes) return;

        products.Remove(current);
        RefreshGrid();
        if (products.Count == 0) ClearInputs();
    }

    private void SelectRowById(string id)
    {
        foreach (DataGridViewRow row in dgvProducts.Rows)
        {
            if (row.DataBoundItem is Product p && p.ProductId == id)
            {
                dgvProducts.ClearSelection();
                row.Selected = true;
                dgvProducts.CurrentCell = row.Cells[0];
                return;
            }
        }
    }

    private void ClearInputs()
    {
        txtId.Clear();
        txtName.Clear();
        txtPrice.Clear();
        nudQuantity.Value = 0;
        cboCategory.SelectedIndex = 0;
    }

    private static void Warn(string message)
        => MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
