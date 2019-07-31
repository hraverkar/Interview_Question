using System;

namespace ConsoleApp53
{
  class Program
  {
    static void Main()
    {
      var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      var len = arr.Length;
      LeftRotate(arr,5,len);
      PrintArray(len, arr);
    }

    private static void LeftRotate(int[] arr, int v, int len)
    {
      for(int i=0;i<v;i++)
      {
        LeftRotateByOrder(arr, len);
      }
    }

    private static void LeftRotateByOrder(int[] arr, int len)
    {
      int i, temp = arr[0];
      for(i=0;i<len-1;i++)
      {
        arr[i] = arr[i + 1];
      }
      arr[i] = temp;
    }

    private static void PrintArray(int len, int[] arr)
    {
     for(int i=0;i<len;i++)
      {
        Console.WriteLine(arr[i] + " ");
      }
    }
  }
}
