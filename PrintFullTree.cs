using System;

namespace ConsoleApp44
{
  public class Node
  {
    public int data;
    public Node right;
    public Node left;

    public Node(int data)
    {
      this.data = data;
      right = left = null;
    }
  }
  class BinaryTree
  {
    public Node root;
    public void PrintPaths(Node node)
    {
      int[] paths = new int[1000];
      PrintPathsRecursive(node, paths, 0);
    }

    private void PrintPathsRecursive(Node node, int[] paths, int v)
    {
      if (node == null)
        return;

      paths[v] = node.data;
      v++;

      if(node.left == null && node.right == null)
      {
        PrintArray(paths, v);
      }
      else
      {
        PrintPathsRecursive(node.left, paths, v);
        PrintPathsRecursive(node.right, paths, v);
      }
    }

    public void PrintArray(int[] ints,int len)
    {
      for(int i=0;i<len;i++)
      {
        Console.Write(ints[i] + " ");
      }
      Console.WriteLine(" ");
    }

    static void Main()
    {
      BinaryTree binaryTree = new BinaryTree();
      binaryTree.root = new Node(1);
      binaryTree.root.left = new Node(2);
      binaryTree.root.right = new Node(3);
      binaryTree.root.left.left = new Node(4);
      binaryTree.root.left.right = new Node(5);
      binaryTree.root.right.left = new Node(6);
      binaryTree.root.right.right = new Node(7);

      binaryTree.PrintPaths(binaryTree.root);

    }
  }
}
