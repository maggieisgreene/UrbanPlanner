using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            City NewYorkCity = new City("New York City", "Bill De Blasio", 1624);

            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 81,
                Width = 100,
                Depth = 2987
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("John Wark");

            Building OneFourOnePark = new Building("141 Park Avenue")
            {
                Stories = 4,
                Width = 389,
                Depth = 567
            };

            OneFourOnePark.Construct();
            OneFourOnePark.Purchase("Bill Lee");

            NewYorkCity.AddBuilding(FiveOneTwoEigth);
            NewYorkCity.AddBuilding(OneFourOnePark);

            foreach (Building building in NewYorkCity.Buildings)
            {
                building.Print();
            }
        }
    }
}