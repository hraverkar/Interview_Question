using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp47
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      var arr = new int[] {0,1,2,3,5 };
      GetSum(arr);
    }

    private static void GetSum(int[] arr)
    {
      int n = arr.Length;
      int sum = n * (n + 1) / 2;
      int arrySum = arr.Sum();
      var a = sum - arrySum;
      Console.WriteLine(a);


      int xor = 0; int i;
      for(i=0;i<arr.Length;i++)
      {
        xor = xor ^ i ^ arr[i];
      }
      var t = xor ^ i;
      Console.WriteLine("Hello element is " + t);
    }
  }
}
