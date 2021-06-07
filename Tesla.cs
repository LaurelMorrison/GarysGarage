using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} car never stops.");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} vehicle turns right smoothly.");
        }
    }
}