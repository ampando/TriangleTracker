using System;
using System.Collections.Generic;
using Triangle.Models;

namespace Triangle 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Enter three numbers");
      string sideOneInput = Console.ReadLine();
      string sideTwoInput = Console.ReadLine();
      string sideThreeInput = Console.ReadLine();

      int sideOne = int.Parse(sideOneInput);
      int sideTwo = int.Parse(sideTwoInput);
      int sideThree = int.Parse(sideThreeInput);

      Tracker isATriangle = new Tracker();
      Console.WriteLine(isATriangle.IsTriangle(sideOne, sideTwo, sideThree));

    }
  }
}