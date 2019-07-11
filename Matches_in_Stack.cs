using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp45
{
  public class Program
  {
    public static void Main()
    {
      string str = "{[[[}]]}";
      var len = str.Length;
      var t = IsBalanced(str);
      Console.WriteLine(t);
    }

    private static bool IsBalanced(string str)
    {
      Dictionary<char, char> dictionary = new Dictionary<char, char>()
      { {'(',')'},
        {'{','}' },
        {'[',']' },
        { '<','>'}
      };

      Stack<char> brackets = new Stack<char>();
      try
      {
        foreach (char c in str)
        {
          if (dictionary.Keys.Contains(c))
          {
            brackets.Push(c);
          }
          else
          {
            if (dictionary.Values.Contains(c))
            {
              if (c == dictionary[brackets.First()])
              {
                brackets.Pop();
              }
              else
                return false;
            }
            else
              continue;
          }
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
      return brackets.Count() == 0 ? true : false;
    }
  }
}
