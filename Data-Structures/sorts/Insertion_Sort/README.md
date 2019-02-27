# Insertion Sort

Insertion sort is a simple, stable sorting algorithm. Insertion sort iterates over each item in the array, storing that item; then, previous items are shifted to the right until the correct, sorted location is found, and the value is placed.

## Challenge
Implement a method that conducts an insertion sort on an array of integers.

## Approach and Efficiency
My implementation iterates through each item in the array, storing the value in a temp variable. 
Because the first element is inherently sorted, and every index we have previously iterated over has been sorted, we know the items before this index are sorted. A second loop iterates backwards through the previous elements in the array, checking if they belong after the element saved in temp; if they do, they are moved one index to the right, and the second loop continues to iterate backward until an element that belongs before the element stored in temp (or the start of the array) is found. When it is, the element is placed after it; all other elements have been moved over one space.

Because we have to potentially consider every preceding value for each index in the array, the worst-case time efficiency is O(N!). 
We are not storing any additional data with the exception of a single temp variable, so the space consumed is O(1).

I provided both the integer-specific implementation that sorts integer arrays from small to large, and a type-generic version that accepts an array as well as an ordering function.
