using System.Drawing.Drawing2D;

namespace Bai5_4;

/// <summary>
/// Bài 5.4: Trình quản lý nhân sự dạng cây (TreeView) và danh sách chi tiết (ListView).
/// </summary>
public partial class MainForm : Form
{
    private const string Root = "Công ty ABC";

    // Chỉ số biểu tượng trong ImageList.
    private const int IconCompany = 0, IconDepartment = 1, IconGroup = 2, IconPerson = 3;

    private readonly List<Employee> employees = new()
    {
        new() { Id = "NV001", FullName = "Nguyễn Minh Tuấn", Position = "Trưởng phòng", StartDate = new(2018, 3, 12), Path = $"{Root}/Phòng Kỹ thuật" },
        new() { Id = "NV002", FullName = "Trần Thị Hạnh", Position = "Lập trình viên", StartDate = new(2020, 7, 1), Path = $"{Root}/Phòng Kỹ thuật/Nhóm Backend" },
        new() { Id = "NV003", FullName = "Lê Quốc Bảo", Position = "Lập trình viên", StartDate = new(2021, 1, 18), Path = $"{Root}/Phòng Kỹ thuật/Nhóm Backend" },
        new() { Id = "NV004", FullName = "Phạm Thu Trang", Position = "Thiết kế giao diện", StartDate = new(2022, 5, 9), Path = $"{Root}/Phòng Kỹ thuật/Nhóm Frontend" },
        new() { Id = "NV005", FullName = "Võ Hoàng Nam", Position = "Lập trình viên", StartDate = new(2023, 2, 20), Path = $"{Root}/Phòng Kỹ thuật/Nhóm Frontend" },
        new() { Id = "NV006", FullName = "Đặng Ngọc Lan", Position = "Kiểm thử viên", StartDate = new(2021, 9, 6), Path = $"{Root}/Phòng Kỹ thuật/Nhóm QA" },
        new() { Id = "NV007", FullName = "Bùi Văn Khoa", Position = "Trưởng phòng", StartDate = new(2017, 11, 2), Path = $"{Root}/Phòng Kinh doanh" },
        new() { Id = "NV008", FullName = "Hoàng Thị Mai", Position = "Nhân viên bán hàng", StartDate = new(2022, 8, 15), Path = $"{Root}/Phòng Kinh doanh/Nhóm Bán lẻ" },
        new() { Id = "NV009", FullName = "Ngô Đức Thịnh", Position = "Nhân viên bán hàng", StartDate = new(2023, 4, 3), Path = $"{Root}/Phòng Kinh doanh/Nhóm Bán lẻ" },
        new() { Id = "NV010", FullName = "Đỗ Thanh Vân", Position = "Quản lý khách hàng", StartDate = new(2019, 12, 10), Path = $"{Root}/Phòng Kinh doanh/Nhóm Doanh nghiệp" },
        new() { Id = "NV011", FullName = "Lý Gia Huy", Position = "Chuyên viên tuyển dụng", StartDate = new(2020, 10, 26), Path = $"{Root}/Phòng Nhân sự/Nhóm Tuyển dụng" },
        new() { Id = "NV012", FullName = "Trương Mỹ Linh", Position = "Chuyên viên đào tạo", StartDate = new(2021, 6, 14), Path = $"{Root}/Phòng Nhân sự/Nhóm Đào tạo" },
    };

    public MainForm()
    {
        InitializeComponent();

        BuildImageLists();
        BuildTree();
        cboView.SelectedIndex = 0;
        Shown += (_, _) => split.SplitterDistance = Math.Min(280, split.Width / 3);
        tvDepartments.SelectedNode = tvDepartments.Nodes[0];
    }

    private void CboView_SelectedIndexChanged(object? sender, EventArgs e) => ApplyView();

    private void TvDepartments_AfterSelect(object? sender, TreeViewEventArgs e) => LoadEmployees(e.Node);

    /// <summary>Xây dựng cấu trúc cây mẫu: Công ty -> Phòng ban -> Nhóm.</summary>
    private void BuildTree()
    {
        var root = new TreeNode(Root) { ImageIndex = IconCompany, SelectedImageIndex = IconCompany };

        TreeNode Dept(string name, params string[] groups)
        {
            var node = new TreeNode(name) { ImageIndex = IconDepartment, SelectedImageIndex = IconDepartment };
            foreach (var g in groups)
                node.Nodes.Add(new TreeNode(g) { ImageIndex = IconGroup, SelectedImageIndex = IconGroup });
            return node;
        }

        root.Nodes.Add(Dept("Phòng Kỹ thuật", "Nhóm Backend", "Nhóm Frontend", "Nhóm QA"));
        root.Nodes.Add(Dept("Phòng Kinh doanh", "Nhóm Bán lẻ", "Nhóm Doanh nghiệp"));
        root.Nodes.Add(Dept("Phòng Nhân sự", "Nhóm Tuyển dụng", "Nhóm Đào tạo"));

        tvDepartments.Nodes.Add(root);
        root.ExpandAll();
    }

    /// <summary>Lọc nhân viên thuộc node đang chọn (bao gồm các node con) và nạp vào ListView.</summary>
    private void LoadEmployees(TreeNode? node)
    {
        lsvEmployees.BeginUpdate();
        lsvEmployees.Items.Clear();
        if (node != null)
        {
            string path = node.FullPath;
            var matched = employees
                .Where(e => e.Path == path || e.Path.StartsWith(path + "/", StringComparison.Ordinal))
                .OrderBy(e => e.Id);

            foreach (var emp in matched)
            {
                var item = new ListViewItem(emp.Id) { ImageIndex = IconPerson };
                item.SubItems.Add(emp.FullName);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));
                lsvEmployees.Items.Add(item);
            }
            lblStatus.Text = $"{node.Text}: {lsvEmployees.Items.Count} nhân viên";
        }
        lsvEmployees.EndUpdate();
    }

    private void ApplyView()
    {
        lsvEmployees.View = cboView.SelectedItem?.ToString() switch
        {
            "SmallIcon" => View.SmallIcon,
            "LargeIcon" => View.LargeIcon,
            "Tile" => View.Tile,
            "List" => View.List,
            _ => View.Details,
        };
    }

    private void BuildImageLists()
    {
        var colors = new[]
        {
            Color.FromArgb(52, 90, 160),   // công ty
            Color.FromArgb(214, 140, 30),  // phòng ban
            Color.FromArgb(46, 140, 100),  // nhóm
            Color.FromArgb(110, 80, 160),  // nhân viên
        };

        for (int kind = 0; kind < 4; kind++)
        {
            imgSmall.Images.Add(DrawIcon(20, kind, colors[kind]));
            imgLarge.Images.Add(DrawIcon(40, kind, colors[kind]));
        }
    }

    /// <summary>Vẽ biểu tượng đơn giản bằng GDI+ để không phụ thuộc file ảnh bên ngoài.</summary>
    private static Bitmap DrawIcon(int size, int kind, Color color)
    {
        var bmp = new Bitmap(size, size);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);
        using var brush = new SolidBrush(color);
        using var light = new SolidBrush(Color.White);
        float u = size / 20f;

        switch (kind)
        {
            case IconCompany: // tòa nhà
                g.FillRectangle(brush, 3 * u, 2 * u, 14 * u, 16 * u);
                foreach (var (x, y) in new[] { (5, 4), (11, 4), (5, 8), (11, 8), (5, 12), (11, 12) })
                    g.FillRectangle(light, x * u, y * u, 4 * u, 2.5f * u);
                break;
            case IconDepartment: // thư mục
                g.FillRectangle(brush, 2 * u, 4 * u, 7 * u, 3 * u);
                g.FillRectangle(brush, 2 * u, 6 * u, 16 * u, 11 * u);
                break;
            case IconGroup: // nhóm người
                g.FillEllipse(brush, 3 * u, 4 * u, 6 * u, 6 * u);
                g.FillEllipse(brush, 11 * u, 4 * u, 6 * u, 6 * u);
                g.FillEllipse(brush, 1 * u, 11 * u, 10 * u, 8 * u);
                g.FillEllipse(brush, 9 * u, 11 * u, 10 * u, 8 * u);
                break;
            default: // một người
                g.FillEllipse(brush, 6 * u, 2 * u, 8 * u, 8 * u);
                g.FillEllipse(brush, 3 * u, 11 * u, 14 * u, 9 * u);
                break;
        }
        return bmp;
    }
}
