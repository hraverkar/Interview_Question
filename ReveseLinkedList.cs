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
    public void AddNode(Node node)
    {
      if (head == null)
        head = node;
      else
      {
        Node temp = head;
        while (temp.next != null)
        {
          temp = temp.next;
        }
        temp.next = node;
      }
    }

    public void ReverseList()
    {
      Node prev = null;
      Node current = head;
      Node next = null;
      while (current != null)
      {
        next = current.next;
        current.next = prev;
        prev = current;
        current = next;
      }
      head = prev;
    }

    public void PrintList()
    {
      Node current = head;
      while (current != null)
      {
        Console.Write(current.data + " ");
        current = current.next;
      }
      Console.WriteLine();
    }
  }
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      LinkedList lk = new LinkedList();
      lk.AddNode(new LinkedList.Node(85));
      lk.AddNode(new LinkedList.Node(15));
      lk.AddNode(new LinkedList.Node(25));
      lk.AddNode(new LinkedList.Node(30));
      lk.AddNode(new LinkedList.Node(45));
      Console.WriteLine("Given linked list:");
      lk.PrintList();
      lk.ReverseList();
      Console.WriteLine("Reversed linked list:");
      lk.PrintList();
    }
  }
}
