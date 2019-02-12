# Generate Balanced Parentheses Combinations

## Challenge
Create a method that, given an integer `n`, returns an array of all possible `n` balanced parentheses pairs. 

For example, if `n=2`, the method should return `["()()", "(())"]`.

## Approach and efficiency
I utilize a recursive helper method to build possible permutations and add them to a list of strings.

The recursive helper method takes in string, an integer representing how many open brackets are "left" to place in the string, a second integer that represents how many closed brackets may legally be placed, and the list that finished permutations will be added to.

If there are no open brackets left to place, a ")" for every closed bracket that may legally be placed is added to the string, and the string is added to the list. This is the base case for the recursive function; adding all remaining closing brackets reduces the number of recursive calls that must be made compared to my original "whiteboarded" solution.

Else,

 If there are still opens left to place, the recursive helper is called, passing in the string + "(", the given number of open parentheses that may be placed - 1, the given number of closing brackets that may be placed + 1, and the list.
      
 If there are still closing brackets left to place, the recursive helper is called, this time passing in the string + ")", the given number of open parentheses left to place, the given number of closing parentheses that may be placed - 1, and the list.
     


This approach takes O(2^N) time; because we must generate every single permutation, and we have about two options (minus many exceptions) for each space, the number of total calls we must make is in terms of 2 ^ n.
This approach takes O(n) space; because the maximum height of our call stack is purely dependent on how many spaces we must fill, i.e. twice the size of n, the space required should be in terms of n. 

## Solution
![Whiteboard solution for balanced parentheses permutations](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/ParensPermutations.jpg)
![Extra whiteboarded content associated with parentheses permutations solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/ParensPermutations2.jpg)
