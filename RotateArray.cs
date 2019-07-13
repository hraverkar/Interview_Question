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
      var arr = new int[] {1,2,3,4,5,6,7 };
      var len = arr.Length;
      var k = 3;
      GetSum(arr,len,k);
    }

    private static void GetSum(int[] arr,int len, int k)
    {
      k = k % len;
      reverse(arr,0, len - 1);
      reverse(arr, 0, k - 1);
      reverse(arr, k, len - 1);
    }

    private static void reverse(int[] arr, int v, int v1)
    {
      while(v < v1)
      {
        int temp = arr[v];
        arr[v] = arr[v1];
        arr[v1] = temp;
        v++;
        v1--;
      }
      foreach(var t in arr)
      Console.WriteLine(t);
    }
  }
}
