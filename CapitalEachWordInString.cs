using System;


namespace ConsoleApp57
{
 
  class Test
  {
    public static void Main()
    {
      string str = "hello harshal raverkar";
      Capital(str);      
    }

    private static void Capital(string str)
    {
      var st = str.Split(' ');
      
      foreach(var t in st)
      {
        var k = t.ToCharArray();

        var p =char.ToUpper(k[0]) + t.Substring(1);
        Console.Write(p+" " );
      }
 
    }
  }
}

