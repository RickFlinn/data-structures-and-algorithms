## Challenge
Given a binary tree of numeric values, return the maximum value in the tree.

## Approach
This solution uses a breadth-first traversal, similar to my previous implementation of breadthfirst, that Queues each level of the tree,
and then dequeues one at a time, reassigning the maximum value if the dequeued value is larger, and then adding the node's children to the queue,
until there are no Nodes remaining; then, the maximum value is returned. 


## Solution
![Whiteboard solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/FindMaxValueWhiteboard.JPG)
