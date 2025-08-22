using grad_joi_delivery_dotnet.Models;

namespace grad_joi_delivery_dotnet.StaticData
{
    public static class SeedData
    {
        private const string ZONEA = "ZoneA";
        private const string ZONEB = "ZoneB";
        private const string ZONEC = "ZoneC";

        public static readonly IReadOnlyList<DistanceMap> DistanceMap = new List<DistanceMap>
        {
            new DistanceMap(ZONEA, ZONEA, 0),
            new DistanceMap(ZONEA, ZONEB, 3),
            new DistanceMap(ZONEA, ZONEC, 6),
            new DistanceMap(ZONEB, ZONEC, 3),
            new DistanceMap(ZONEB, ZONEB, 0),
            new DistanceMap(ZONEC, ZONEC, 0)
        }.AsReadOnly();
        

        public static readonly List<Item> Items = new List<Item>
        {
            new Item("P1001", "Notebook", "Note books", 60, Category.DEFAULT),
            new Item("P1002", "Keyboard", "Key board", 120, Category.DEFAULT),
            new Item("P1003", "Mouse", "mouse", 250, Category.DEFAULT),
            new Item("P1004", "Monitor", "monitor", 90, Category.DEFAULT)
        };
      
        public static List<Store> Stores = new List<Store>
        {
            new Store("1", ZONEA, new List<string> { "Milk", "Eggs" }),
            new Store("2", ZONEB, new List<string> { "Bread", "Milk" }),
            new Store("3", ZONEC, new List<string> { "Juice", "Bread" })
        };
    }
    
    
}