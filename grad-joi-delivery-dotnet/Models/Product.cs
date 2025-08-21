public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    //public int Ratings { get; set; } // Optional for sorting

    public Product(string id, string name, string category, double price, string description)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
        Description = description;
    }
    
    /*public Product(string name, double price, int ratings)
    {
        Name = name;
        Price = price;
        Ratings = ratings;
    }*/
}