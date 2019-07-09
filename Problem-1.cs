using System;

namespace ConsoleApp42
{
  class Program
  {
    public static void Main()
    {
      double a = 2;
      var t =Square(a);
      Console.WriteLine(t);
    }

    private static double Square(double inputValue)
    {
      double temp;
      double sr = inputValue / 2;
      do
      {
        temp = sr;
        sr = (temp + (inputValue / temp)) / 2;
      } while ((temp - sr) != 0);
      return sr;
    }
  }
}
