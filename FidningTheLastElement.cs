using System;

namespace ConsoleApp55
{
  class LinkedList
  {
    Node head;
    internal class Node
    {
      public int data;
      public Node next;

      public Node(int d)
      {
        this.data = d;
        this.next = null;
      }
    }

   internal void PrintNthFromLast(int n)
    {
      int len = 0;
      Node temp = head;
      while(temp != null)
      {
        temp = temp.next;
        len++;
      }

      if(len < n)
      {
        return;
      }
      temp = head;

      for(int i = 1; i < len - n + 1; i++)
      {
        temp = temp.next;
      }
      Console.WriteLine(temp.data);
    }
    public void Push(int newData)
    {
      Node new_node = new Node(newData);
      new_node.next = head;
      head = new_node;
    }
  }
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      LinkedList lk = new LinkedList();
      lk.Push(20);
      lk.Push(30);
      lk.Push(40);
      lk.Push(50);
      lk.Push(60);
      lk.PrintNthFromLast(5);
    }
  }
}
