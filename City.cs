using System.Collections.Generic;

namespace UrbanPlanner
{
  public class City
  {
    public string CityName { get; set; }
    public string CityMayor { get; set; }
    public int CityEstablishment { get; set; }

    public List<Building> Buildings = new List<Building>();

    public void AddBuilding(Building building)
    {
      Buildings.Add(building);
    }

    public City(string name, string mayor, int year)
    {
      CityName = name;
      CityMayor = mayor;
      CityEstablishment = year;
    }
  }
}