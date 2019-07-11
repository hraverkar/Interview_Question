using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp45
{
  public class Program
  {
    static void SortedInsert(Stack s, int c)
    {
      if(s.Count == 0 || c > (int)s.Peek())
      {
        s.Push(c);
        return;
      }

      int temp = (int)s.Peek();
      s.Pop();
      SortedInsert(s, c);
      s.Push(temp);
    }


    static void sortedStack(Stack s)
    {
      if(s.Count >0)
      {
        int x = (int)s.Peek();
        s.Pop();
        sortedStack(s);
        SortedInsert(s, x);
      }
    }

    static void printStack(Stack s)
    {
      foreach (int c in s)
      {
        Console.Write(c + " ");
      }
    }
    public static void Main()
    {
      Stack s = new Stack();
      s.Push(30);
      s.Push(-5);
      s.Push(18);
      s.Push(14);
      s.Push(-3);

      Console.WriteLine("Stack elements before sorting: ");
      printStack(s);

      sortedStack(s);

      Console.WriteLine(" \n\nStack elements after sorting:");
      printStack(s);
    }

   
  }
}
