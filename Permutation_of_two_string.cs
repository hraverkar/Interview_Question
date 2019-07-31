using System;
/*
 check two given string are a permutation of each other or not.
 A Permutation of a string is another string that contains the same characters, 
 Only the order of the characters can be different 
 Example "abcd" and "dabc" are a permutation of each other.
 */

namespace ConsoleApp53
{
  class Program
  {
    public static void Main()
    {
      string str1 = "abcd";
      string str2 = "bcda";
      var t =arePermutation(str1, str2);
      if(t)
      {
        Console.WriteLine(" string is permutation");
      }
      else
      {
        Console.WriteLine("string is not permutation ");
      }
    }

    private static bool arePermutation(string str1, string str2)
    {
      int n1 = str1.Length;
      int n2 = str2.Length;

      if (n1 != n2)
        return false;
      char[] ch1 = str1.ToCharArray();
      char[] ch2 = str2.ToCharArray();

      Array.Sort(ch1);
      Array.Sort(ch2);

      for(int i=0;i<n1;i++)
      {
        if (ch1[i] != ch2[i])
          return false;
      }
      return true;
    }
  }
}
