# Linked List
> Classes for a singly linked list.

## Objective
The objective of this challenge is to create new object classes for a singly linked list and associated nodes.
This class is to have methods for adding new items to the list, checking whether the linked list contains a given value,
and printing all of the list's values to console. 

## Approach
Two new classes, LinkedList and Node, were created. Nodes simply contain two public properties for an integer value and
the location of the next Node in the list, if it exists. LinkedLists contain two properties - Head, which stores the location of
the first Node in the list if it exists, and Current, which stores the Node we are currently working with, and is used for 
traversing the list. 

The LinkedList class has six public methods. 

The first, Insert, takes in an integer value, and creates a new Node object storing that value, then inserts
that Node into the beginning of the list. First, it checks to see if the list is empty (Head is null); if so, it sets Head to this new Node. If the list
already contains one or more Nodes, the current value of Head is stored in Current, Head is reassigned to the new Node, the new Node's 
Next property is set to the previous Head Node stored in Current.

Includes has takes in an integer, and returns a boolean value indicating whether the value exists in the linked list.
It does this by using a while loop to iterate over the list, and return true if the value is found.
If it is not, the method returns false.

PrintListValues takes in no parameters and returns void. When the method is called, the Linked List is traversed, and each Node's value is
printed to Console.

Append adds a new Node with a given integer value to the end of the list. If the list contains no Nodes, the new Head node is instantiated by calling the Insert method. If the list already contains Nodes, this method iterates to the end of the list, and sets the Next property of the last Node to the new Node.

InsertBefore takes in a search key and a value. It iterates over the list, and if it finds a Node with a value matching the Search key,
a new Node with the given value is created, given the same Next value as the key Node's parent, and then the parent of the key Node's Next property is set to the new Node.

InsertAfter behaves similarly to InsertBefore, but places the new Node after the key Node. When the key Node is found, a new Node is generated with the given value and its Next is set to the Next value of the key Node. Then, The key Node's Next is reassigned to the new Node.

```C#
LinkedList list = new LinkedList();
list.Insert(4);
list.Insert(7);
list.Insert(8);

// The list now contains Nodes with the  values 8, 7, and 4. 

list.Includes(4); // returns true; the list contains the value 4
list.Includes(5); // returns false; the list does not contain this value

list.Append(2);
list.InsertBefore(7, 10);
list.InsertAfter(4, 3);

list.PrintListValues(); 
```
Prints to Console:

```
Node 1 contains value 8

Node 2 contains value 10

Node 3 contains value 7

Node 4 contains value 4

Node 5 contains value 3

Node 6 contains value 2
```
