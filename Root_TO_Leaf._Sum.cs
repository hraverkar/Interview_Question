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
    public static int maxLen;
    public static int maxSum;


    Node root;
    public static void sumofLongRootTOLeafPath(Node root, int sum, int len)
    {
      if(root == null)
      {
        if(maxLen < len)
        {
          maxLen = len;
          maxSum = sum;
        }
        else if(maxLen == len && maxSum < sum)
        {
          maxSum = sum;
        }
        return;
      }
      sumofLongRootTOLeafPath(root.left, sum + root.data, len + 1);
      sumofLongRootTOLeafPath(root.right, sum + root.data, len + 1);
    }

    public static int sumofLongRootToLeafPathUtil(Node root)
    {
      if (root == null)
        return 0;
      maxSum = int.MinValue;
      maxLen = 0;
      sumofLongRootTOLeafPath(root, 0, 0);
      return maxSum;
    }
 
    public static void Main()
    {
      //BinaryTree binaryTree = new BinaryTree();

      Node root = new Node(1);
      root.left = new Node(2);
      root.right = new Node(3);
      root.left.left = new Node(4);
      root.left.right = new Node(5);
      root.right.left = new Node(6);
      root.right.right = new Node(7);
      root.right.right = new Node(7);
      root.left.left.left = new Node(8);

      Console.WriteLine("Sum : " + sumofLongRootToLeafPathUtil(root));
    }
  }
}
