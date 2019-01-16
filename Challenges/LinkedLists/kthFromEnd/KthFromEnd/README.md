# KthFromEnd challenge

The purpose of this challenge is to add a method, KthFromEnd, to my LinkedList class that takes in an integer, k, and returns the 
value in the node kth from the end of the list. 

For example, say we have a LinkedList called `list` with the following chain of values:

```(HEAD)1 -> 2 -> 3 -> 4```

If we were to call the KthFromEnd method on `list`, feeding the the value "3" for `k`, we would return the value `1`.

## Approach 
KthFromEnd iterates over our list, adding to a counter for every new node. This counter represents the length of the list. 
Then, we return to the beginning of the list, traversing length - k nodes, and returning this node.
This approach is somewhat inefficient, requiring an O(2N), as we must iterate over the length of the list twice.

## Solution
![Whiteboard img](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/whiteboardllk.jpg "asdf")

