# MultiBracketValidation

## Challenge
The challenge was to create a method that verifies if a given string contains valid code bracket pairs. 
I.e., an input of `{{}}` returns `true`, but `((`, `(}`, and `{(})` return `false`.

## Approach
My method instantiates a single Stack object, then iterates through each character in the given string.
For each character, it checks if the character is an opening bracket; if so, it adds the character onto the stack.
If the character is a closing bracket, it checks if the stack is empty, or if it contains its opening bracket pair. 
If the character on top of the stack is its opening pair, the opening bracket on top of the stack is popped. 
If it doesn't, or if the stack is empty, returns `false`.
Once each character has been checked, the stack is checked. If it still contains opening brackets, i.e. there are still
unmatched bracket pairs, returns `false`.
If the stack is empty, i.e. all bracket pairs have been correctly matched, returns `true`.

This approach costs O(N) time and memory; the number of actions and required space is dependent on the size of the input string.

## Solution
![MultiBracketValidation solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/MultiBracketWhiteboard.jpg)
