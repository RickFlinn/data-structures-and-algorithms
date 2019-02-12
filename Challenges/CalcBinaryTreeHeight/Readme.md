# CalcBinaryTreeHeight

## Challenge
Create a method that, given a binary tree's root node, calculates its and returns its height as an integer.

Stretch goal: create a similar method that calculates the number of levels in the given tree. 

## Approach
I use a recursive approach to determine the depth of the tree. 

First, my recursive method checks if the given node has children. If it doesn't, the node is leaf and 0 is returned, the base case for the recursive

If the given node only has a right or left child, the recursive method is called and returned on the right or left child respectively.

If both children exist, the recursive method is called on both, and the values returned are compared. The larger of the two values is then returned, as it is the "longer" path of the two, and the height of the tree is always defined by the longest route between a leaf and the root node.

The stretch goal method uses an almost identical implementation; the recursive method, when fed a leaf, returns 1 instead of 0 as the base case; the number of levels in a tree includes the root node, and will always be 1 more than the height of the tree.

## Solution
!["Whiteboad solution"](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/CalcBinaryTreeHeight.jpg)
