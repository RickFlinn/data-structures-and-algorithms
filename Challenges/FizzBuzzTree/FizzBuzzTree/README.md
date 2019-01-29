# FizzBuzzTree
> Perform FizzBuzz on a binary tree

## Challenge 
Create a method that converts each Node's value in a given Binary tree into "Fizz" if it is divisible by 3, "Buzz" if it is divisible by 5,
and "FizzBuzz" if it is divisible by 3 and 5.

## Approach
The method itself contains only a single call to its recursive helper method, passing in the given Tree's root node.

The recursive helper takes in a node as a parameter, and if the Node isn't null, checks if the node's value is divisible by 3 and 5. 
  If so, its value is reassigned to "FizzBuzz".
  If the value is only divisible by 3, reassign it to "Fizz".
  If the value is only divisible by 5, reassign it to "Buzz".

Then, the recursive helper calls itself on the node's right and left children.

Originally, a temporary string was created and "Fizz" and "Buzz" added to it, and if the string wasn't empty, the Node's value was reassigned.
This was chosen to maximize the speed of operations, but was changed for space reasons - the temporary variable would persist on the recursive call stack.
Additionally, originally the null-node check occurred on the node's children, but this required a separate check to see if the original node's root was null,
and was refactored for simplicity's sake.

## Solution

