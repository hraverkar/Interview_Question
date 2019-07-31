using System;
/*
 * Stack ::: 
 */

namespace ConsoleApp53
{
  public class Stack
  {
    static readonly int MAX = 1000;
    int top;
    int[] stack = new int[MAX];

    bool IsEmpty()
    {
      return (top < 0);
    }

    public Stack()
    {
      top = -1;
    }

    internal bool Push(int data)
    {
      if(top >= MAX)
      {
        Console.WriteLine("Stack is Overflow");
        return false;
      } else
      {
        stack[++top] = data;
        return true;
      }
    }

    internal int Pop()
    {
      if(top< 0)
      {
        Console.WriteLine("Stack is Underflow");
        return 0;
      }
      else
      {
        int value = stack[top--];
        return value;
      }
    }

    internal void Peek()
    {
      if(top <0)
      {
        Console.WriteLine("Stack underflow");
        return;
      }
      else
      {
        Console.WriteLine("the top most element is : " + stack[top]);
      }
    }
    internal void PrintStack()
    {
      if(top < 0)
      {
        Console.WriteLine("Stack is underflow");
      }
      else
      {
        Console.WriteLine("Item present in the stack are :");
        for(int i=top;i>=0;i--)
        {
          Console.WriteLine(stack[i]);
        }
      }
    }
  }
  class Program
  {
    public static void Main()
    {
      var stack = new Stack();
      stack.Push(12);
      stack.Push(23);
      stack.Push(32);
      stack.Push(22);
      stack.Push(3);
      stack.PrintStack();
      stack.Pop();
      stack.Pop();
      stack.PrintStack();
      stack.Peek();
    }
  }
}
