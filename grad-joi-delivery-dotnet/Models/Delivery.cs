namespace grad_joi_delivery_dotnet.Models
{
    public class Delivery
    {
        public int? TimeInMinutes { get; set; }
        public double Distance { get; set; }

        public Delivery() {}

        public Delivery(int? timeInMinutes, double distance)
        {
            TimeInMinutes = timeInMinutes;
            Distance = distance;
        }
    }
}