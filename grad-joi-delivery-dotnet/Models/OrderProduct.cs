public class OrderProduct
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double PricePerUnit { get; set; }

    public OrderProduct(string productId, string productName, int quantity, double pricePerUnit)
    {
        ProductId = productId;
        ProductName = productName;
        Quantity = quantity;
        PricePerUnit = pricePerUnit;
    }
}