using System;
using System.Collections;

namespace ConsoleApp45
{

  public class MyStack
  {
    public Stack stack;
    public int minElement;

    public MyStack()
    {
      stack = new Stack();
    }

    public void getMin()
    {
      if (stack.Count == 0)
        Console.WriteLine("Stack is empty");
      else
        Console.WriteLine("Minimum Element in the stack is :" + minElement);
    }

    public void Peek()
    {
      if (stack.Count == 0)
      {
        Console.WriteLine("Stack is empty");
        return;
      }
      int t = (int)stack.Peek();
      Console.WriteLine("Top Most Element is ");
      if (t < minElement)
        Console.WriteLine(minElement);
      else
        Console.WriteLine(t);
    }

    public void Pop()
    {
      if (stack.Count == 0)
      {
        Console.WriteLine("Stack is empty");
        return;
      }
      Console.WriteLine("Top Most Element Removed: ");
      int t = (int)stack.Pop();
      if (t < minElement)
      {
        Console.WriteLine(minElement);
        minElement = 2 * minElement - t;
      }
      else
        Console.WriteLine(t);
    }

    public void Push(int x)
    {
      if (stack.Count == 0)
      {
        minElement = x;
        stack.Push(x);
        Console.WriteLine("Number Inserted : " + x);
        return;
      }
      if (x < minElement)
      {
        stack.Push(2 * x - minElement);
        minElement = x;
      }
      else
      {
        stack.Push(x);
        Console.WriteLine("Number Inserted " + x);
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      MyStack stack = new MyStack();
      stack.Push(3);
      stack.Push(5);
      stack.getMin();
      stack.Push(2);
      stack.Push(1);
      stack.getMin();
      stack.Pop();
      stack.getMin();
      stack.Pop();
      stack.Peek();
    }
  }
}
