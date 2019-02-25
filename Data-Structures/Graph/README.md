# Graph
Implement the Graph data structure.

Graphs are a fundamental structure in Computer Science, and can be described as the parent of all other data structures. 
Graphs have Nodes containing values, and Nodes have connections to other Nodes in the Graph; however, there are no limitations on which Nodes can be linked together, and how. 
Indeed, not all Node clusters must be contiguous in a Graph. This means that Graphs must contain explicit information for the "adjacencies" in the Graph,
or connections between Nodes. In addition, some Graphs assign "weights" to these connections. 

## Approach and Efficiency
The first question I had to answer with my implementation was how I was going to store information on adjacencies for each Node.
I chose to store information on adjacencies on the Nodes themselves; each Node has a Value and a List of adjacencies,
where adjacencies are represented as a Tuple containing a Node and a nullable integer representing the weight of the connection.
The Graph itself simply contains a HashSet of all the Nodes it contains. 

Each method defined in this implementation requires O(1) time to complete. Because the Graph stores all of its nodes in a HashSet, checking if they exist within that HashSet is an O(1) operation; all other functionality either adds individual items to the Generic HashSet or List implementations, O(1) operations, or returns one of those collections directly.

## API
#### `public Node AddNode(object value)`
Takes in a value, creates a Node, adds it to the graph, then returns a reference to that Node. 

#### `public bool AddNode(Node node)`
Takes in a Node, and attempts to add it to the Graph. If that Node already exists in the Graph, nothing happens and false is returned, indicating the Node already exists.
If it is new to the Graph, it is added to the HashSet of Nodes, and true is returned.

#### `public void AddEdge(Node node1, Node node2)`
Adds a connection between two edges, adding each Node to the other's adjacency list with a weight of `null`.

#### `public void AddEdge(Node node)`
Adds a connection from a Node to itself. 

#### `public void AddEdge(Node node1, Node node2, int weight)`
Adds a connection between two edges, adding each Node to the other's adjacency list with the given weight.

#### `public void AddEdge(Node node, int weight)`
Adds a connection from the Node to itself with the given weight.

#### `public IEnumerable<Node> GetNodes()`
Returns all Nodes in the Graph, or null if it contains no Nodes.

#### `public IEnumerable<Tuple<Node, int?>> GetNeighbors(Node node)`
Takes in the given Node, and returns all of its adjacencies.

#### `public int Size()`
Returns the total number of Nodes in the Graph.
