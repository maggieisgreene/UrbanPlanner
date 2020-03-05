using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 81,
                Width = 100,
                Depth = 2987
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("John Wark");

            Console.WriteLine($"{FiveOneTwoEigth.Volume} cubic meters of space");
        }
    }
}