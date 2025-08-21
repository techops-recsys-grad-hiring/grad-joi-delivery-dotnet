public class InventoryItem
{
    public string ProductId { get; set; }
    public int Stock { get; set; }
    public int Sold { get; set; }

    public InventoryItem(string productId, int stock, int sold)
    {
        ProductId = productId;
        Stock = stock;
        Sold = sold;
    }
}