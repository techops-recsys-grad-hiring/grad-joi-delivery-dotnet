namespace grad_joi_delivery_dotnet.Problems
{
    public class SampleProblem
    {
        public static void Run()
        {
            double cost = CalculateCost(8.0); // Example distance
            Console.WriteLine($"Delivery cost for 8 km: ₹{cost}");
        }

        public static double CalculateCost(double distanceKm)
        {
            if (distanceKm <= 0)
            {
                throw new ArgumentException("Distance must be positive");
            }

            double baseCost = 50.0;
            if (distanceKm <= 5)
            {
                return baseCost;
            }
            else
            {
                double extraDistance = distanceKm - 5;
                return baseCost + (extraDistance * 10);
            }
        }
    }
}