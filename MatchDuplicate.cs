using System;
using System.Collections.Generic;

namespace ConsoleApp47
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      var arr = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
      GetDuplicate(arr);
    }

    private static void GetDuplicate(int[] arr)
    {
      List<int> list = new List<int>();
      for(int i=0;i<arr.Length;i++)
      {
        for(int j=i+1;j<arr.Length;j++)
        {
          if(arr[i] == arr[j])
          {
            list.Add(arr[i]);
          }
        }
      }
      foreach(int v in list)
      {
        Console.WriteLine(v);
      }
    }
  }
}
