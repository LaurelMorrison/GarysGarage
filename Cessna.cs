using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("Zoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} vehicle slams on it's brakes.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} vehicle U-turns twice.");
        }
    }
}