public class OrderItem
{
    public string Name { get; set; }
    public double PricePerUnit { get; set; }

    public OrderItem(string name, double pricePerUnit)
    {
        Name = name;
        PricePerUnit = pricePerUnit;
    }
}