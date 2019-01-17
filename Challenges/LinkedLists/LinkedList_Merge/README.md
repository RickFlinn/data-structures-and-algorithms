# LinkedList Merge

The purpose of the challenge was to create a static method that takes in two LinkedList objects as parameters and attempts to 
"zip" the two together, and returns the newly merged LinkedList.
For example, if we had two linked lists with the following values:

`1 -> 3 -> 5 -> 7'

`2 -> 4 -> 6 -> 8 -> 10`

The method should return a linked list with these values:

`1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 10`

## Approach


The method first defines a temporary Node-typed reference variable called `zipper` that will be used to 'zip' individual nodes by modifying
their `Next` property. It then checks if the first list is empty, returning the second list if it is. 
Then, a while loop and the `zipper` variable are used to modify each Node's `Next` properties, 
and advances the `Current` properties of each lists prior to each "zip" to prevent the loss of the rest of the list.

## Solution

Note that the function of temp (our zipper) and list1.Current have been reversed; there is no functional difference, 
but the final solution is more clearly readable this way.

![merge solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/whiteboard_ll_merge.jpg)






