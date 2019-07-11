Print all paths of a binary tree.


initialize: pathlen = 0, path[1000] 
/*1000 is some max limit for paths, it can change*/

/*printPathsRecur traverses nodes of tree in preorder */
printPathsRecur(tree, path[], pathlen)
   1) If node is not NULL then 
         a) push data to path array: 
                path[pathlen] = node->data.
         b) increment pathlen 
                pathlen++
   2) If node is a leaf node then print the path array.
   3) Else
        a) Call printPathsRecur for left subtree
                 printPathsRecur(node->left, path, pathLen)
        b) Call printPathsRecur for right subtree.
                printPathsRecur(node->right, path, pathLen)
                
     1        
		/ \       
	 2   3      
	/ \ / \     
 4  5 6  7 
 
 Print all the ---- 
 
 ![Output](https://i.ibb.co/LvBMnK4/Vs-Debug-Console-V8-Ijubg9e-V.png)
