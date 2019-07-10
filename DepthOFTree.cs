using System;

namespace ConsoleApp43
{

  public class Node
  {
    public int data;
    public Node left, right;

    public Node(int data)
    {
      this.data = data;
      left = right = null;
    }
  }
  class BinaryTree
  {
    Node root;
    int maxDepth(Node node)
    {
      if (node == null)
        return 0;
      else
      {
        int lDepth = maxDepth(node.left);
        int rDepth = maxDepth(node.right);
        if(lDepth > rDepth)
        {
          return (lDepth + 1);
        }
        else
        {
          return (rDepth + 1);
        }
      }
    }

    public static void Main()
    {
      BinaryTree binaryTree = new BinaryTree();

      binaryTree.root = new Node(1);
      binaryTree.root.left = new Node(2);
      binaryTree.root.right = new Node(3);
      binaryTree.root.left.left = new Node(4);
      binaryTree.root.left.right = new Node(5);
      binaryTree.root.right.left = new Node(6);
      binaryTree.root.right.right = new Node(7);
      binaryTree.root.right.right = new Node(7);
      binaryTree.root.left.left.left = new Node(8);
      Console.WriteLine("Height of tree is : " + binaryTree.maxDepth(binaryTree.root));
    }
  }
}
