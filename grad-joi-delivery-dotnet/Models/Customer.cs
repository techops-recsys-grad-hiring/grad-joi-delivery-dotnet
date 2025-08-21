namespace grad_joi_delivery_dotnet.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoyaltyPoints { get; set; }
        public LoyaltyTier Tier { get; set; }

        public Customer() {}

        public Customer(string customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }
        public Customer(string customerId, string firstName, string lastName, string loyaltyPoints, LoyaltyTier tier)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            LoyaltyPoints = loyaltyPoints;
            Tier = tier;
        }
    }
}