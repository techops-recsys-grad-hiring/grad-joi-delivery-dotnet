namespace grad_joi_delivery_dotnet.Models
{
    public class DistanceMap
    {
        public string ZoneTo { get; set; }
        public string ZoneFrom { get; set; }
        public int Distance { get; set; }

        public DistanceMap() {}

        public DistanceMap(string zoneTo, string zoneFrom, int distance)
        {
            ZoneTo = zoneTo;
            ZoneFrom = zoneFrom;
            Distance = distance;
        }
    }
}