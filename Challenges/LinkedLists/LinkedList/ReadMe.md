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

The LinkedList class has three public methods. 

The first, Insert, takes in an integer value, and creates a new Node object storing that value, then inserts
that Node into the list. First, it checks to see if the list is empty (Head is null); if so, it sets Head to this new Node. If the list
already contains one or more Nodes, the current value of Head is stored in Current, Head is reassigned to the new Node, the new Node's 
Next property is set to the previous Head Node stored in Current, and the Current property is reset the new Head Node. 

Includes has takes in an integer, and returns a boolean value indicating whether the value exists in the linked list.
It does this by using a while loop to check the value stored in the Node referred to by Current, and returning true if the value matches;
if it does not, Current is reassigned to the Node in its Next property (Current.Next). It will continue looping until the value of Current is 
null (i.e., there are no more Nodes in the list); if it exits this loop without finding the given value, it will return false.

PrintListValues takes in no parameters and returns void. When the method is called, the Linked List is traversed, and each Node's value is
printed to Console.



```C#
LinkedList list = new LinkedList();
list.Insert(4);
list.Insert(7);
list.Insert(8);

// The list now contains Nodes with the  values 8, 7, and 4. 

list.Includes(4); // returns true; the list contains the value 4
list.Includes(5); // returns false; the list does not contain this value

list.PrintListValues();
```
Prints to Console:

` Node 1 contains value 8

 Node 2 contains value 7

 Node 3 contains value 4
`
