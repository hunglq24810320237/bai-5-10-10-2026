namespace Bai5_4;

public class Employee
{
    public string Id { get; init; } = "";
    public string FullName { get; init; } = "";
    public string Position { get; init; } = "";
    public DateTime StartDate { get; init; }

    /// <summary>Đường dẫn nhóm trong cây, ví dụ "Công ty ABC/Phòng Kỹ thuật/Nhóm Backend".</summary>
    public string Path { get; init; } = "";
}
