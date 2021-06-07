using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"My car color is {MainColor}!");
        }

        public virtual void Turn()
        {
            Console.WriteLine($"The {MainColor} takes a sharp right turn.");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The {MainColor} comes to a gentle stop.");
        }
    }
}