# Left Join
## Challenge
Take in two HashTables, and perform a LEFT JOIN on each of them.

A LEFT JOIN takes all columns from the "Left" table, and appends any columns from the "Right" table with specific matching values.

In the context of this challenge, a LEFT JOIN will return all key-value pairs from the Left table along with values from the Right table with the corresponding key, if they exist.

## Approach and Efficiency
My approach first iterates through all values in the backing array of the Left hashtable; because values are stored in buckets, we check if there is a bucket at each index in the backing array, and if it is, we iterate over each Key-Value Pair in the bucket.
For each key-value pair, we create a new three-length array, wiht the fist two indexes assigned to the key and value of the key-value pair, respectively. Then, the third index is assigned to the value returned by a Get method call on the Right HashTable, using the key as an argument. This array is then added to a List.

When all key-value pairs in the left array have been added to the list along with the joined values from teh right table, this list is returned.

Because we must iterate through every single item in the Left HashTable, but only perform one constant set of actions for each, this approach has O(N) time efficiency.
Because we must store each item in our left table, as well as all corresponding items in the right table, the required space is directly dependent on the size of the data set - this approach has O(N) space efficiency.

## Solution
![Problem domain and visual](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/LeftJoinHashTable%20(1).jpg)
![Algorithm](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/LeftJoinHashTable%20(3).jpg)
![PseudoCode solution](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/LeftJoinHashTable%20(2).jpg)
![Big O and Edge Cases](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/LeftJoinHashTable.jpg)
