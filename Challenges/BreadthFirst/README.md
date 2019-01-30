# BreadthFirst
> Print the values in a binary tree using breadth-first traversal.

## Challenge
Create a method that takes in a Binary Tree, and then prints each of its values. 
This method should print the values in a breadth-first pattern. This means that each layer of the tree should be printed, in order, before
the next layer of their children. For example, if we had the following tree structure:

``` 
       1
     /   \
    2     3
  /  \    / \ 
 4    5  6   7
            /
           8
```
With this tree fed into our BreadthFirst method we should see the following output to our Console:
` 1 2 3 4 5 6 7 8 `

## Approach
Our solution maintains breadth-first ordering by utilizing a Queue data structure.
First, the root of the given tree is Enqueued. 
Then, we set up a while loop that continues as long as there are Nodes in the queue.
  Inside this while loop, we first Peek the TreeNode stored at the Front of the Queue.
   If this TreeNode has children, they are Enqueued. 
  Then, we print the TreeNode's Value, and Dequeue it.
  
Because we are always adding the children of a TreeNode to the end of the Queue, they will not be printed until we have first
interacted with all of its sibling Nodes; i.e., because 2 and 3, the children of 1, were Enqueued successively, we will print them and add their children
before we interact with the children themselves. This means that, any any one point, there are no more than two "layers" of our tree in 
the Queue at any given time.

Because we Enqueue and print every Node in the tree, and take only one set of actions to do so for each, this method takes O(N) Time.
Because we never contain more than two "layers" within our Queue, how much memory we use is dependent on the Width of the tree - this method takes O(W) Space.

## Solution
![Whiteboard Solution - Problem Domain](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/BreadthFirst.jpg)
![Whiteboard Solution - Algorithm](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/BreadthFirst%20(2).jpg)
![Whiteboard Solution - PsuedoCode 1](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/BreadthFirst%20(3).jpg)
![Whiteboard Solution - PsuedoCode 2](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/BreadthFirst%20(4).jpg)
