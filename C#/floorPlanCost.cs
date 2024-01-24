using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double length = 2500;
      double width = 1500;
      double radius = 375;
      double bottom = 750;
      double height = 500;
      double floorArea = (rectArea + circArea + triArea);
      double areaCost = (floorArea * 180);
      Console.WriteLine($"The total build cost for this floor plan is: {areaCost}");
    }
    public static double Rect(double length, double width)
    {
      double rectArea = (length * width);
      out rectArea;
    }
    public static double Circ(double radius)
    {
      double circArea = (Math.PI * (Math.Pow(radius)));
    out circArea;
    }
    public static double Triangle(double bottom, double height)
    double triArea = (0.5 * bottom * height);
    out triArea;
    {

    }
  }
}
