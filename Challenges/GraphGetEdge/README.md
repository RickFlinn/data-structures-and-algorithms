# GetEdge
## Challenge
Given an array of strings, representing names of cities in a travel itinerary (or values of Nodes to travel between), and a Graph whose values are names of cities, and whose adjacencies represent direct connections, with the weight as the price:

Return whether the given itinerary is possible using only direct flights, i.e. direct adjacencies, in the order given. Additionally, return the price of a valid flight itinerary.

## Approach and Efficiency
First, we need to find the correct starting Node. I search through the list of Nodes contained within my Graph implementation until I find the Node with the same value as the first index of the itinerary.
Once I have this starting node, I set it to a variable `current` which tracks my current position within the graph. I also define an integer variable, `price`, that tracks the cumulative weight of the connections in the trip. 

For every other index in the itinerary, I look through the current node's adjacencies for a node with the next value contained in the itinerary. If one isn't found, I return a Tuple containing `false` and `0`; the given itinerary is not possible using direct connections.

If an adjacency with the desired Node is found, I set `current` to that Node, and add the adjacency's weight to `price`. 

After all itinerary items have been traversed, a Tuple containing "true" and the price is returned. 

This approach has an O(i * l) time efficiency, where i is the number of items in our itinerary (not our complete dataset), and l is the average size of their adjacency list. We are, at most, only examining the nodes and associated adjacency lists of nodes described in the itinerary path. 
This solution requires O(1) space because this solution does not store additional pieces of data based on the number of items within the graph.

## Solution
![Problem Domain and Visual](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/GetEdgeGraph%20(1).jpg)
![Algorithm and PseudoCode](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/GetEdgeGraph%20(2).jpg)
