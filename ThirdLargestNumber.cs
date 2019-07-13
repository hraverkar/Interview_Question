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
      int length = arr.Length;
      int first = arr[0];
      for(int i =1;i<length;i++)
      {
        if (arr[i] > first)
          first = arr[i];
      }

      int second = -int.MaxValue;
      for(int j =0;j<length;j++)
      {
        if(arr[j] > second && arr[j] < first)
        {
          second = arr[j];
        }
      }

      int third = -int.MaxValue;
      for(int i=0;i<length;i++)
      {
        if (arr[i] > third && arr[i] < second)
          third = arr[i];
      }
      Console.Write("The third Largest element is " + third);
    }
  }
}
