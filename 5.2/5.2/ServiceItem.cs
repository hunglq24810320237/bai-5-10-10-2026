namespace Bai5_2;

/// <summary>Một dịch vụ y tế gồm tên và đơn giá.</summary>
public class ServiceItem
{
    public string Name { get; }
    public decimal Price { get; }

    public ServiceItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Name} - {Price.ToString("N0", MainForm.Vn)} đ";
}
