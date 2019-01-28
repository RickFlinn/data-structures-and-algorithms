# Trees
Trees are a data structure consisting of linked Nodes. Unlike stacks, queues, and linked lists, each Node may link to more than one other node in the 
data structure. In a Binary Tree, each Node has references to up to two "child" Nodes, and stores a value. A Binary Search Tree is similar to a 
Binary Tree, where the values are structured in such a way that a Node's left children always contain values that are less than the parent Node's, while
children to the right always store a value greater than their parent Node, so that a value may be searched for by a series of binary (less than or more than) checks - 
hence the term Binary Search Tree.

## Challenge
- Create BinaryTree and BinarySearchTree classes. 
- The BinaryTree class must have three methods: PreOrder, InOrder, and PostOrder. Each returns an array of values by utilizing PreOrder, InOrder, and PostOrder traversals, respectively.
- The BinarySearchTree class must have two methods: Add, which adds a value to the binary search tree, while preserving the binary search tree organization, and contains, which efficiently determines whether the tree contains a value.

## Approach
First, I created a TreeNode class, which contains properties for an integer value and a Left and Right TreeNode child.
The BinaryTree class contains a single property to hold its root TreeNode, and uses recursive helper methods for its PreOrder, InOrder, and PostOrder methods.
The BinarySearchTree class inherits the BinaryTree class. Both Add and Contains recursively navigate through Nodes, going left when the value to add or find is less than the current Node's value
is smaller and right when it is greater, until they reach a leaf/the value is found; Add then adds a new Node there, while Contains returns whether the value exists at that leaf. 

## API

#### BinaryTree - PreOrder, InOrder and PostOrder
All three of these methods are fairly similar in requirement and behavior. All three are intended to return an array of the values in the BinaryTree.
For each of these methods, I defined and called a private recursive helper method that accepts a Node, beginning with the Tree's root, and a list of values.

The PreOrder helper method first adds the given Node's value to the array, and then calls itself on both of the Node's children, passing down the reference to the list.
The InOrder helper method calls itself on its Left child, adds the given Node's value to the list, and then calls itself on its Right child.
The PostOrder helper method calls itself on the Node's children, then adds the Node's value to the list.

For example, if our tree has a structure like so:

       1 (Root)
      / \
     2   3
    /   / \
   4   5   6
   
PreOrder would return `[1, 2, 4, 3, 5, 6]`.
InOrder would return `[4, 2, 1, 5, 3, 6]`.
PostOrder would return `[4, 2, 5, 6, 3, 1]`.

All three methods have an O(N) for time and memory.

#### BinarySearchTree - Add (int val)
This method calls a private recursive helper method to navigate through the tree. Every time it navigates to a Node, beginning at the root, the given integer is checked
against the Node's value. 

If the given value is less than the Node's value, the method calls itself on the Left child, or if there is no Left child, assigns the Node's Left property to a newly instantiated Node storing the given value.

If the given value is greater than or equal to the Node's value, the method calls itself on the Right child, or if there is no Right child, assigns the Node's Right property to a newly instantiated Node storing the given value.

For example, if Add(5) were called on the following binary tree:
     4 (Root)
    / \
   2   6
  / \
 1   3
 
The recursive method would navigate right, because 4 < 5, and then place a new Node to the left of the Node with value 6, because 6 > 5.
The new BinarySearchTree now looks like this:

     4 (Root)
    /  \
   2    6
  /\   /
 1  3  5
 
 
#### BinarySearchTree - Contains (int value)
Contains uses a similar recursive logic as Add to navigate through the tree. It differs in its end behavior/base cases; if it navigates to a Node with the given value, it returns true.
If it navigates to a null Node reference, it returns false. 


