using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} truck thinks it's cool when it stops, but it's still not cool.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} truck looks dumb as it turns.");
        }
    }
}