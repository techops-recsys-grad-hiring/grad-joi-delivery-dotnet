public class StoreInventory
{
    public string StoreId { get; set; }
    public List<InventoryItem> Items { get; set; }

    public StoreInventory(string storeId, List<InventoryItem> items)
    {
        StoreId = storeId;
        Items = items;
    }
}