namespace grad_joi_delivery_dotnet.Models
{
    public enum LoyaltyTier
    {
        DIAMOND = 10,
        GOLD = 5,
        SILVER = 3
    }

    public static class LoyaltyTierExtensions
    {
        public static int GetDiscount(this LoyaltyTier tier)
        {
            return (int)tier;
        }
    }
}