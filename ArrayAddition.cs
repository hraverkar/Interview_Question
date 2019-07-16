using System;
using System.Collections.Generic;

namespace ReturnMaximumOccuringCharacter
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[] { 0, -1, 2, -3, 1 };
      int k = 0;
      var t = findNumber(arr, k);
      if (t == k)
      {
        Console.WriteLine("Yes");
      }
      else
      {
        Console.WriteLine("No");
      }
    }

    private static int findNumber(int[] arr, int u)
    {
      var length = arr.Length;
      var temp = 0;
      for (int i = 0; i < length; i++)
      {
        for (int j = i + 1; j < length; j++)
        {
          for (int k = j + 1; k < length; k++)
          {
            if (arr[i] + arr[j] + arr[k] == u)
            {
              temp = u;
              Console.Write(arr[i]);
              Console.Write(" ");
              Console.Write(arr[j]);
              Console.Write(" ");
              Console.Write(arr[k]);
              Console.Write("\n");
            }
          }
        }
      }
      return temp;
    }
  }
}

