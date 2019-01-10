# ArrayShift

## Challenge
The objective is to take in an array of integers and a single integer as parameters, and returns an array of the given array's values,
shifted so that the given integer may be placed in the center. 

## Approach
First, we instantiate an array with the given array's size + 1, to accommodate the given integer in its center.
Next, we determine the midpoint of the given array. Then, we increment over the first half of the given array's values, assigning
them to the corresponding indexes in our new array, stopping at our midpoint. Then, we begin decrementing over the second half of the 
given array's values from the end, stopping at the midpoint index. This gives us our shifted values. Last, we assign the given integer
to the midpoint of our new array. 

This solution time is O(N), as we take a single set of actions proportional to the number of items in our given array. 
This solution requires O(N) of memory space, as we must reserve a space in memory for our new array, proportional to the given array.

![whiteboard image](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/pic1%20(1).jpg)
![whiteboard image](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/pic2.jpg)
