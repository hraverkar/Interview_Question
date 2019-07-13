using System;

namespace ConsoleApp46
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] numbers = { 3, 1, 2, 4,5,9 };
      twoSum(numbers);   
    }

    private static void twoSum(int[] numbers)
    {
      int left = 0, right = numbers.Length - 1;
      int maxArea = 0;
      while(left<right)
      {
        maxArea = Math.Max(maxArea, Math.Min(numbers[left], numbers[right]) * (right - left));
        if (numbers[left] < numbers[right])
          left++;
        else
          right--;
      }
      Console.WriteLine(maxArea);
    }
  }
}
