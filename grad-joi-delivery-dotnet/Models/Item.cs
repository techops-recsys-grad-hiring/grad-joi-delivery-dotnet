namespace grad_joi_delivery_dotnet.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }

        public Item() {}

        public Item(string id, string name, string description, float price, Category category = Category.DEFAULT)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}