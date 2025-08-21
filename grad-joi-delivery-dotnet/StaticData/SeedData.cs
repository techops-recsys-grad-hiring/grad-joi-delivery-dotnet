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

        
        public static List<Store> Stores = new List<Store>
        {
            new Store("1", ZONEA, new List<string> { "Milk", "Eggs" },new Dictionary<string, int> { { "Milk", 5 }, { "Eggs", 10 } }, 30),
            new Store("2", ZONEB, new List<string> { "Bread", "Milk" },new Dictionary<string, int> { { "Bread", 8 }, { "Milk", 2 } }, 25),
            new Store("3", ZONEC, new List<string> { "Juice", "Bread" },new Dictionary<string, int> { { "Juice", 4 }, { "Bread", 6 } }, 40)
        };

        /*
        public static List<Item> Items = new List<Item>
        {
            new Item("1", "Notebook", "", 15),
            new Item("2", "Keyboard", "", 50),
            new Item("3", "Mouse", "", 25),
            new Item("4", "Monitor", "", 75)
        };
        */

        /*public static List<DeliveryPartner> Partners = new List<DeliveryPartner>
        {
            new DeliveryPartner("101", "Raj", new List<Delivery>
            {
                new Delivery(32, 5),
                new Delivery(28, 3.2),
                new Delivery(35, 6.0)
            }),
            new DeliveryPartner("102", "Neha", new List<Delivery>
            {
                new Delivery(26, 4.5),
                new Delivery(30, 3.5),
                new Delivery(29, 3.0)
            }),
            new DeliveryPartner("103", "Ali", new List<Delivery>
            {
                new Delivery(40, 8.0),
                new Delivery(35, 7.5)
            }),
            new DeliveryPartner("104", "Simran", new List<Delivery>
            {
                new Delivery(22, 2.5),
                new Delivery(25, 2.0),
                new Delivery(28, 2.5)
            }),
            new DeliveryPartner("105", "Zoya", new List<Delivery>
            {
                new Delivery(30, 5.0),
                new Delivery(29, 4.8),
                new Delivery(28, 4.5)
            })
        };*/
        
        public static readonly List<StoreInventory> StoreInventories = new List<StoreInventory>
        {
            new StoreInventory("StoreA", new List<InventoryItem>
            {
                new InventoryItem("Milk", 20, 17),
                new InventoryItem("Eggs", 12, 7),
                new InventoryItem("Bread", 10, 9)
            }),
            new StoreInventory("StoreB", new List<InventoryItem>
            {
                new InventoryItem("Milk", 15, 14),
                new InventoryItem("Eggs", 10, 5),
                new InventoryItem("Butter", 8, 8)
            }),
            // Edge cases
            new StoreInventory("StoreC", new List<InventoryItem>
            {
                new InventoryItem("Cheese", 0, 0),      // remaining = 0
                new InventoryItem("Yogurt", 5, 5),      // remaining = 0
                new InventoryItem("Cream", 3, 8),       // remaining = -5
                new InventoryItem("Jam", 1000000, 999996) // remaining = 4 (large values)
            })
        };

        public static readonly List<OrderItem> OrderItems = new List<OrderItem>
        {
            new OrderItem("Notebook", 15),
            new OrderItem("Keyboard", 50),
            new OrderItem("Mouse", 25),
            new OrderItem("Monitor", 75)
        };
        
        /*
        public static readonly List<Customer> Customers = new List<Customer>
        {
            new Customer("C001", "Amit","C","6", LoyaltyTier.SILVER),
            new Customer("C002", "Priya","K", "12",LoyaltyTier.GOLD),
            new Customer("C003", "Rahul","S","20", LoyaltyTier.DIAMOND)
        };
        */

        /*
        public static readonly List<LoyaltyTransaction> LoyaltyTransactions = new List<LoyaltyTransaction>
        {
            new LoyaltyTransaction("C001", DateTime.UtcNow.AddDays(-2), 240, 2, 0),
            new LoyaltyTransaction("C002", DateTime.UtcNow.AddDays(-1), 500, 10, 0),
            new LoyaltyTransaction("C003", DateTime.UtcNow, 1000, 40, 5)
        };*/
        
        public static readonly List<Item> Items = new List<Item>
        {
            new Item("P1001", "Amul Full Cream Milk", "Dairy", 60, Category.DAIRY),
            new Item("P1002", "Britannia Cheese", "Dairy", 120, Category.DAIRY),
            new Item("P1003", "Aashirvaad Atta", "Grocery", 250, Category.WHEAT_RICE_GRAINS),
            new Item("P1004", "Mother Dairy Paneer", "Dairy", 90, Category.DAIRY),
            new Item("P1005", "Tata Salt", "Grocery", 30, Category.WHEAT_RICE_GRAINS),
            new Item("P1006", "Amul Butter", "Dairy", 55, Category.DAIRY),
            new Item("P1007", "Parle-G Biscuits", "Snacks", 20, Category.SNACKS)
        };
        
        /*public static readonly List<Order> Orders = new List<Order>
        {
            new Order(
                "O1001", "STORE123", new DateTime(2025, 8, 7), OrderStatus.Completed,
                new List<OrderProduct>
                {
                    new OrderProduct("P001", "Organic Milk 1L", 5, 50),
                    new OrderProduct("P002", "Brown Bread", 2, 30)
                }
            ),
            new Order(
                "O1002", "STORE123", new DateTime(2025, 8, 7), OrderStatus.Completed,
                new List<OrderProduct>
                {
                    new OrderProduct("P001", "Organic Milk 1L", 8, 50)
                }
            ),
            new Order(
                "O1003", "STORE123", new DateTime(2025, 8, 7), OrderStatus.Cancelled,
                new List<OrderProduct>
                {
                    new OrderProduct("P002", "Brown Bread", 3, 30)
                }
            ),
            new Order(
                "O1004", "STORE456", new DateTime(2025, 8, 7), OrderStatus.Completed,
                new List<OrderProduct>
                {
                    new OrderProduct("P003", "Paneer 200g", 4, 80)
                }
            ),
            // Orders on a different date
            new Order(
                "O1005", "STORE123", new DateTime(2025, 8, 6), OrderStatus.Completed,
                new List<OrderProduct>
                {
                    new OrderProduct("P001", "Organic Milk 1L", 2, 50)
                }
            )
        };*/
        
        /*public static readonly List<Product> ProductItems = new List<Product>
        {
            new Product("Avocado Taco", 340, 5),
            new Product("Big Veggie Burger", 200, 5),
            new Product("French Fries", 199, 4),
            new Product("Pasta", 140, 4),
            new Product("Salad", 100, 2),
            new Product("Mexican Pizza", 230, 1),
            new Product("Sushi", 220, 1)
        };*/
    }
    
    
}