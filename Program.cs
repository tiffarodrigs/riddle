using System;


namespace Sphinx{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What has to be broken before you can use it?");
      Console.WriteLine(Console.ReadLine().Contains("egg") ? "Correct": "wrong");
    }
  }
}