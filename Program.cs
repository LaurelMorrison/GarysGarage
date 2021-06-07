using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            fxs.MainColor = "black";
            modelS.MainColor = "electric blue";
            mx410.MainColor = "cherry red";
            truck.MainColor = "gross green";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine("------------------");

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine("------------------");

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine("------------------");

            truck.Drive();
            truck.Turn();
            truck.Stop();

        }
    }
}