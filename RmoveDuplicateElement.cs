using System;

namespace ConsoleApp46
{
  class Program
  {
    static void Main()
    {
      int [] arr = { 1, 1, 2 };
      RemoveDuplicate(arr);
    }

    private static void RemoveDuplicate(int[] arr)
    {
      int j = 0;
      for(int i=0;i<arr.Length;i++)
      {
        if (arr[0] == arr[i])
          j++;
      }
      Console.WriteLine(j++);
    }
  }
}
