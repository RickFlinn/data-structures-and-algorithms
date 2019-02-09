# BinaryOddSum

Create a method that takes in a binary search tree of integers, and returns the sum of all odd values in the tree.

## Approach
For my original whiteboard solution, I chose a recursive depth-first traversal over a breadth-first traversal; my logic was that a depth-first traversal would consume O(h) memory, while a breadth-first traversal would be O(w); given that a binary search tree, assuming it isn't just one list-like chain, will always be wider than it is tall, it followed that a depth-first traversal would be more efficient.

This assumption was incorrect. I was unfamiliar with the resources required for individual method calls, and didn't consider the possibility of a stack overflow; knowing this, my implemention uses a breadth-first traversal, which should be substantially more efficient.

My implementation accepts any binary tree of integers; because the binary search structure would only help inform us in very specific situations that would require more logic than would be worthwhile (i.e. if a parent node had a value of 8, and its right child had a value of ten and a left child, we might assume the left child contained a value of 9).

Otherwise, the implementation is fairly simple and mirrors that of previous breadth-first binary tree challenge implementations. A queue and a variable to store the sum are created, the tree's root is enqueued, and while the queue still contains nodes, a node is dequeued, the returned tree node's value is checked to see if it is odd, and if so is added to the sum. If the tree node has any children, they are then enqueued. Finally, the sum is returned.

This implementation requires O(N) time, considering we are traversing over every node in the tree, and O(W) memory, where W is the width of the tree.
