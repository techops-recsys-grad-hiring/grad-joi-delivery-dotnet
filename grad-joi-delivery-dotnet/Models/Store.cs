namespace grad_joi_delivery_dotnet.Models
{
    public class Store
    {
        public string StoreId { get; set; }
        public string Zone { get; set; }
        public List<string> Items { get; set; }
        /*public Dictionary<string, int> Stock { get; set; } = new();
        public int? AvgDeliveryTime { get; set; } //in minutes*/
        
        public Store() {}
        
        public Store(string storeId, string zone, List<String> items,  Dictionary<string, int> stock, int? avgDeliveryTime)
        {
            StoreId = storeId;
            Zone = zone;
            /*Stock = stock;
            AvgDeliveryTime = avgDeliveryTime;*/
            Items = items;
        }
    }
}