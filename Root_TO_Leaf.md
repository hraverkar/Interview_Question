Sum of nodes on the longest path from root to leaf node


Given a binary tree containing n nodes. The problem is to find the sum of all nodes on the longest path from root to leaf node. If two or more paths compete for the longest path, then the path having maximum sum of nodes is being considered.

Examples:

Input : Binary tree:
        4        
       / \       
      2   5      
     / \ / \     
    7  1 2  3    
      /
     6
Output : 13

        1        
       / \       
      2   3      
     / \ / \     
    4  5 6  7 
   /  
  8  

The highlighted nodes (1,2,4,8) above are 
part of the longest root to leaf path having
sum = (1+2+4+8) = 15
