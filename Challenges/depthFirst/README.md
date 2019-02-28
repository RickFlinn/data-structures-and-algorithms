# Depth First Traversal - Graph
## Challenge
Perform a depth-first, preorder traversal of a Graph, returning a collection of Nodes in the order they were traversed.

## Approach and Efficiency
I define a new HashSet used to check whether Ive traversed a Node, a Stack to traverse the graph, and a List to contain the Nodes ive traversed.
While the graph has more items than the list, i look through the graph's internal collection of Nodes until I find one that doesnt exist in the HashSet. I store this Node as root, then add it to the stack and hashset.
While there are still items in the Stack, remove a node from the stack. I add this Node to the List. Then, for each of its adjacencies whose Nodes dont exist in the hashset, add them to the hashset and push to the stack. 
Once all of the graph's Nodes exist in the List, it is returned - we have completed the traversal

Because we use a stack, we will traverse each adjacencies' children before its siblings (depthfirst traversal); because each
Node is added to the List before we deal with its children, the returned List is pre-ordered(i.e., parents are added before their children).

This approach requires O(n * a) (n = size of dataset, a = average adjacencies) for most graphs, as we have to perform traversals both over each item in the graph itself, and each adjacency must be evaluaated individually. In the worst case that none of the nodes are connected, the solution is O(n!), as we have to traverse the list of all nodes repeatedly until we find a Node that hasnt been added. The solutiom requires O(n) space, as each node is stored in the stack/list and hashset.
 


## Solution 
![Problem Domain](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/2019_02_28%2010_55%20AM%20Office%20Lens.jpg)
![Visual](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/2019_02_28%2010_56%20AM%20Office%20Lens.jpg)
![Big O / Edge Cases](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/2019_02_28%2010_56%20AM%20Office%20Lens%20(1).jpg)
![Algorithm](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/2019_02_28%2010_58%20AM%20Office%20Lens.jpg)
![PseudoCode](https://github.com/RickFlinn/data-structures-and-algorithms/blob/master/assets/2019_02_28%2010_58%20AM%20Office%20Lens%20(1).jpg)


