using System;

namespace ConsoleApp45
{
  public class Program
  {
    public static void Main()
    {
      int[] a = { 1, 2, 3 };
      HeapPermutation(a, a.Length, a.Length);
    }

    private static void HeapPermutation(int[] a, int length1, int length2)
    {
      if (length1 == 1)
        PrintArr(a, length2);

      for(int i= 0;i<length1;i++)
      {
        HeapPermutation(a, length1 - 1, length2);


        if(length1 % 2 == 1)
        {
          int temp = a[0];
          a[0] = a[length1 - 1];
          a[length1 - 1] = temp;
        }
        else
        {
          int temp = a[i];
          a[i] = a[length1 - 1];
          a[length1 - 1] = temp;
        }
      }
    }

    private static void PrintArr(int[] a, int length2)
    {
      for(int i =0;i<length2;i++)
        Console.Write(a[i] + " " );
      Console.WriteLine();
    }
  }
}
