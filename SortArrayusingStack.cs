using System;
using System.Collections;
using System.Collections.Generic;

/*  
  HashTable use key value pair to store data in Object.
  In HashTable it's very easy to search any value as HashTable maintain key to identify specific value.
 */
namespace ConsoleApp55
{
  class Program
  {
    public static void Main()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(12);
      stack.Push(2);
      stack.Push(23);
      stack.Push(20);
      stack.Push(98);
      stack.Push(56);

      Stack<int> temmstack = sortStack(stack);

      while(temmstack.Count >0)
      {
        Console.WriteLine(temmstack.Pop() + " ");
      }
    }

    private static Stack<int> sortStack(Stack<int> stack)
    {
      Stack<int> tmpstack = new Stack<int>();
      while (stack.Count > 0)
      {
        int tmp = stack.Pop();

        while (tmpstack.Count > 0 && tmpstack.Peek() > tmp)
        {
          stack.Push(tmpstack.Pop());
        }
        tmpstack.Push(tmp);
      }
      return tmpstack;
    }
  }
}
