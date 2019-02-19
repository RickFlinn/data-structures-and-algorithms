# Repeated Word

## Challenge
Create a method that takes in a long string, and returns the first repeated word in the string.

## Approach and efficiency
My approach uses my HashTable implementation and a temporary string variable to build and store words, and an integer iterator variable to store character index within the string.
A while loop traverses over the string while there are still characters in the string. 
An inner while loop first advances the iterator until an alphabetic character is found. 
A second inner while loop adds the character located at the index of the iterator to the temp string, and advances the iterator, continuing until a non-alphabetic character is encountered.

Once a non-alphabetic character is found, i.e. temp contains a single, contiguous word, the HashTable is checked to see if it contains the temp string as a key. If it does, return the temp string; it is the first repeated word.
If not, the temp string is added as a key to the HashTable, with the value "1". Temp is then reset to an empty string, and the process repeats.

This method requires O(N) time - because HashTables have O(1) lookup time, we only take one subset of actions for each character, but we still have to iterate over each character in the string until a repeated word is found.
It should require O(N) space as well - each non-repeated word is stored in a HashTable, so the storage required is in terms of the size of the string.

## Solution
![Whiteboard solution - Problem domain and visual](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/RepeatedWord%20(2).jpg)
![Whiteboard solution - Algorithm and PseudoCode](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/RepeatedWord%20(1).jpg)
