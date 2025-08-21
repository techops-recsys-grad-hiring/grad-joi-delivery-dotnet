namespace grad_joi_delivery_dotnet.Models
{
    public class DeliveryPartner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Delivery> Deliveries { get; set; }

        public DeliveryPartner() {}

        public DeliveryPartner(string id, string name, List<Delivery> deliveries)
        {
            Id = id;
            Name = name;
            Deliveries = deliveries;
        }
    }
}