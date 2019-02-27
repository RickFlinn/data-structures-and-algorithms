# HashTable

A hash table is a data structure that allows storage of key-value pairs with O(1) key lookup time.

Hash tables store key-value pairs in an array. A key value pair is accessed by its string key; the key is converted into an integer index by a Hash function, and the value placed or retrieved at that index.


## Challenge
Create a class that implements a HashTable, with Add, Get, Contains, and Hash methods.

HashTables use a Hash function to convert a string key into an integer index, and place a key-value pair at that index.

## Approach and Efficiency
I use a non-resizing backing array with size 1024 as the fundamental storage object of my HashTable. This backing array does not resize, and is an array of `List` objects; each `List`, in turn, is a list of `KeyValuePair`s, a two-value struct built in to the C# language, with string keys and object values.

Each time a given key is hashed, the ASCII value of all characters in the key string are summed, and then multiplied by a large prime number (677).
The index is the remainder of this product, divided by 1024 - then length of the array. This returns only valid indexes of the backing array - the remainder of any integer value divided by 1024 will always be between 0 and 1023.

When an item is added to the HashTable, its key is hashed and used to access an index of the backing array. If no bucket yet exists, one is instantiated; then, the given key and value are placed into a KeyValuePair struct, and added to the bucket.

With a perfect hash function, the Add, Get and Contains methods should all consume only O(1) time - because we are using the key to directly access an array index, the size of the dataset is irrelevant; we are only ever considering one bucket of information, and a perfect hash function would ensure two items were never placed in the same bucket.
However, I have not created a perfect hash function or the ability to resize the backing array. Because of this, the average lookup time should be O(aL), where aL is the average Load of items in all buckets within the array, because we have to iterate through each item stored in a bucket. 
## API
#### `int Hash(string key)`
The given key is converted into an integer, that represents the index at which the given key would be stored.

This is how the HashTable decides where to place and retrieve items; all other methods are dependent on it.

#### `void Add(string key, object value)`
Takes in a string key, and an object value. It then hashes the key into an integer index.

The method first attempts to access that key within the HashTable. 
If it can find a key-value pair with the given key, an error is thrown - HashTables may not contain duplicates of the same key.
If the key hasn't been taken, the bucket at the index is checked. 
If that bucket is null - i.e., no key-value pair has been assigned to this index - a new List object is instantiated to the bucket.
Then, the key-value pair is added to the bucket.

#### `object Get(string key)`
The given key is hashed, and the bucket at the index checked. 
If the bucket has not been instantiated, i.e. no value has been placed at that index, null is returned.
If there is a bucket, each item in the bucket is checked. If an item contains the given key, the value is returned.
If the bucket contains no item with the given key, null is returned.

#### `bool Contains(string key)`
Returns whether the HashTable contains the given key.
Looks up the bucket at the hashed key index. Then, each item in the bucket is iterated through; if the bucket is empty, or the bucket does not contain a key-value pair with the given key, false is returned. If the key is found, returns true.
