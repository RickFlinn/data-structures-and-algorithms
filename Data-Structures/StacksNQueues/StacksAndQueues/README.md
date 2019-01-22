# Stacks and Queues

`Stack`s and `Queue`s are similar data structures that consist of linked `Node` objects.

`Node`s contain as properties an integer value and a reference to the next `Node` in a data structure.

`Stack`s "stack `Node`s on top of one another"; adding, removing, or viewing a `Node` is always performed on the `Node` on `Top` of the stack.
Thus, the first Node added is the last Node removed, and vice versa.
A similar real-life example might be a Pez dispenser.

`Queue`s consist of linked `Node`s, but `Node`s may only be added to the `End` of the `Queue`, while Nodes may only be removed from the `Front`
of the `Queue`. The first `Node` added is the first `Node` removed, and the last `Node` added is the last removed.
A similar real-life example might be a line for a movie - the first person to enter the line is the first person to see the film. 

## Challenge
To create standalone classes for Nodes, Stacks and Queues. 

Nodes must have the following properties: 
  Value - integer value contained by the Node
  Next - reference to the next Node in the data structure


Stacks must have the following properties and methods:
  Top - the Node on top of the Stack
  Pop() - removes and returns the Node on Top of the Stack
  Peek() - returns the Node on Top of the Stack without removing it
  Push(Node node) - adds given Node on Top of the other Nodes in the Stack
  
Queues must have the following properties and methods:
  Front - the Node at the Front of the Queue
  End - the Node at the End of the Queue
  Enqueue(Node node) - adds given Node to the End of the Queue
  Dequeue() - removes and returns Node at the Front of the Queue
  Peek() - returns Node at the Front of the Queue
  
## Approach

### Stack
  
#### Push(Node node)
If the Stack is empty, assigns the given Node to Top. 
If not, assigns the given Node's Next property to the current value of Top, then reassigns Top to the given Node.

#### Pop()
If the Stack is empty, throws and catches a NullReferenceException, displays a console message stating that the Stack is empty, and returns `null`.
If not, stores the current reference in Top in a Node reference variable called `popped`, assigns the value of Top to its Next, clears `popped`'s Next property, and returns `popped`.

#### Peek() 
Returns the Node (or null) stored by Top.

### Queue

#### Enqueue(Node node)
If the Queue is empty, assigns Front and End to the given Node.
If not, assigns the current End's Next to the given Node, then reassigns End to the given Node.

#### Dequeue()
If the Queue is empty, displays Console message stating that the Queue is empty, and returns null.
If not, uses a temp variable `dqueued` to store the value at Front, reassigns Front to its Next, and clears `dqueued`'s Next, and returns `dqueued`.

#### Peek() 
Returns the Node (or null) stored by Front.
