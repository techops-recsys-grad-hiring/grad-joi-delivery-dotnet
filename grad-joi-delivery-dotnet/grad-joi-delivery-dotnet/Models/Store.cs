namespace grad_joi_delivery_dotnet.Models
{
    public class Store
    {
        public string StoreId { get; set; }
        public string Zone { get; set; }
        public List<string> Items { get; set; }
        public Store() {}
        
        public Store(string storeId, string zone, List<String> items)
        {
            StoreId = storeId;
            Zone = zone;
            Items = items;
        }
    }
}