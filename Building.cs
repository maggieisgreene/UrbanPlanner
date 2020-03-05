using System;

namespace UrbanPlanner
{
  public class Building
  {
    private string _designer = "Maggie Greene";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume
    {
      get
      {
        return Width * Depth * (3 * Stories);
      }
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string owner)
    {
      _owner = owner;
    }

    public Building(string address)
    {
      _address = address;
    }
  }
}