# Queues with Stacks

The Queue data structure consists of linked Nodes. Nodes can only be removed, or viewed, at the Front of the list, while Nodes may only be added to the Rear - Queues follow a First In First Out pattern.
The PseudoQueue class implements the functionality of a Queue, but internally utilizes two Stacks to emulate a Queue's behavior.


## Challenge
The idea of this challenge is to replicate the behavior of a Queue using only two Stacks internally.
Queues have three methods - Enqueue, which adds a Node to the Queue, Dequeue, which removes a Node, and Peek, which allows us to 
view the Node at the Front of the Queue (potentially the next to be removed).

## Approach
My initial approach used a Main and a Helper stack. When a Node was Enqueued, each Node in Main would be moved to the Helper Stack, the 
new Node added on top of the Helper stack, and all Nodes would then be pushed back into the Main stack. This allowed Peek and Dequeue to simply Peek and Pop
the Main stack, and would emulate the FIFO behavior of a stack, but was inefficient.

My revised approach defined an In and an Out stack. When Nodes were Enqueued, they would simply be pushed into the In stack. Whenever 
Peek or Dequeue were called, a helper method first checks if there are Nodes in the Out stack. If there are not, all Nodes in the In 
stack would be pushed into the Out stack, reversing their order, and Peek and Dequeue would simply Peek or Pop the out stack. 
This dramatically improved efficiency from O(N^2) to O(N) maximum operations. 

## Initial Solution
![Initial Whiteboard Solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/QueueWithStacks.jpg "Whiteboard solution")
![Initial Whiteboard Solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/QueueWithStacks2.jpg "Whiteboard solution")

