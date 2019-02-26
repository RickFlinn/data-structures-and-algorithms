using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public HashSet<Node> Nodes { get; set; }

        public Graph()
        {
            Nodes = new HashSet<Node>();
        }


        
        /// <summary>
        ///   Takes in a value, creates a Node to hold it, and adds that Node to the Graph. 
        ///   Then, return the created Node.
        /// </summary>
        /// <param name="value"> Value to place in new Node </param>
        /// <returns> New Node that has been added to the graph </returns>
        public Node AddNode(object value)
        {
            Node node = new Node(value);
            Nodes.Add(node);
            return node;
        }

        
        /// <summary>
        ///     Takes in a Node. If that Node does not exist within the Graph, the Node is added and the method returns true.
        ///     If the Node already exists within the graph, the method returns false.
        ///     
        /// </summary>
        /// <param name="node"> Node to add to the Graph </param>
        /// <returns> Indicates whether Node was added to the graph; false indicates the Node already existed and was not added. </returns>
        public bool AddNode(Node node)
        {
            if (!Nodes.Contains(node))
            {
                Nodes.Add(node);
                return true;
            }
            else return false;
        }


        /// <summary>
        ///     Adds a connection between two Nodes in the Graph. 
        /// </summary>
        /// <param name="node1">First Node to connect</param>
        /// <param name="node2">Second Node to connect</param>
        public void AddEdge(Node node1, Node node2)
        {
            if (!Nodes.Contains(node1) || !Nodes.Contains(node2))
                throw new ArgumentOutOfRangeException("The Graph must already contain both nodes to add a connection between them.");

            node1.Adjacencies.Add(new Tuple<Node, int?>(node2, null));
            node2.Adjacencies.Add(new Tuple<Node, int?>(node1, null));
        }

        /// <summary>
        ///     Gives a node a new connection to itself.
        /// </summary>
        /// <param name="node"> Node to add self-referential adjacency to </param>
        public void AddEdge(Node node)
        {
            if (!Nodes.Contains(node)) throw new ArgumentOutOfRangeException("Given Node does not exist in this Graph.");

            node.Adjacencies.Add(new Tuple<Node, int?>(node, null));
        }

       
        /// <summary>
        ///     Gives a node a new connection to itself with the given weight.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="weight"></param>
        public void AddEdge(Node node, int weight)
        {
            if (!Nodes.Contains(node)) throw new ArgumentOutOfRangeException("Given Node does not exist in this Graph.");

            node.Adjacencies.Add(new Tuple<Node, int?>(node, weight));
        }

        /// <summary>
        ///     Adds an adjacency connection between the given nodes with the given weight.
        /// </summary>
        /// <param name="node1">First Node to connect</param>
        /// <param name="node2">Second Node to connect </param>
        /// <param name="weight">Weight to assign to the adjacency</param>
        public void AddEdge(Node node1, Node node2, int? weight)
        {
            if (!Nodes.Contains(node1) || !Nodes.Contains(node2))
                throw new ArgumentOutOfRangeException("The Graph must already contain both nodes to add a connection between them.");

            node1.Adjacencies.Add(new Tuple<Node, int?>(node2, weight));
            node2.Adjacencies.Add(new Tuple<Node, int?>(node1, weight));
        }

        /// <summary>
        ///     Returns all Nodes contained in the Graph.
        /// </summary>
        /// <returns>IEnumerable of all Nodes contained in Graph</returns>
        public IEnumerable<Node> GetNodes()
        {
            return Nodes.Count > 0 ? Nodes : null;
        }


        /// <summary>
        ///     Takes in a given Node; if that Node exists within the Graph, returns all of that Node's adjacenct nodes,
        ///     along with the weight of each connection.
        /// </summary>
        /// <param name="node"> Node to determine adjacencies for </param>
        /// <returns> IEnumerable of Node-weight tuples, representing the given Node's adjacencies </returns>
        public IEnumerable<Tuple<Node, int?>> GetNeighbors(Node node)
        {
            if (!Nodes.Contains(node))
                throw new ArgumentOutOfRangeException("The Graph does not contain the given Node.");

            return node.Adjacencies;
        }

        /// <summary>
        ///     Returns the total number of Nodes contained within the Graph.
        /// </summary>
        /// <returns> Number of Nodes in this Graph </returns>
        public int Size()
        {
            return Nodes.Count;
        }

        /// <summary>
        /// 
        ///     Takes in a "root" node, and performs a breadth-first traversal of the Graph. I.e., as each node is traversed, all
        ///     of its adjacent nodes that have not been traversed are queued for traversal.
        ///     
        ///     When all Nodes have been traversed, an array of all nodes traversed is returned. 
        ///     
        /// </summary>
        /// <param name="root"> "Root" Node of the graph to traverse from </param>
        /// <returns> Array of all Nodes traversed, in the order they were traversed </returns>
        public Node[] BreadthFirst(Node root)
        {
            if (!Nodes.Contains(root))
                throw new ArgumentOutOfRangeException("Given Node does not exist inside this Graph.");

            Node[] nodes = new Node[Size()];
            HashSet<Node> set = new HashSet<Node>();
            Queue<Node> q = new Queue<Node>();
            set.Add(root);
            q.Enqueue(root);
            int index = 0;
            while (q.Count > 0)
            {
                Node node = q.Dequeue();
                List<Node> adjacencies = node.Adjacencies.Select(adj => adj.Item1).ToList();
                foreach (Node adjNode in adjacencies)
                {
                    if (!set.Contains(adjNode))
                    {
                        set.Add(adjNode);
                        q.Enqueue(adjNode);
                    }
                }
                nodes[index] = node;
                index++;
            }
            return nodes;
        }
    }
}
