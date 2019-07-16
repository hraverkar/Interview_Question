using System;

namespace PowerFunction
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var t =pow(5, 3);
      Console.WriteLine(t);
    }

    private static int pow(int v1, int v2)
    {
      if (v2 == 0)
        return 1;
      int answer = v1;
      int increment = v1;
      for(int i=1;i<v2;i++)
      {
        for(int j=1;j<v1;j++)
        {
          answer += increment;
        }
        increment = answer;
      }
      return answer;
    }
  }
}
