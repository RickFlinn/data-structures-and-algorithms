using System;
using System.Collections.Generic;
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


        // Takes in a value, creates a Node to hold it, and adds that Node to the Graph. 
        //  Returns the created Node.
        public Node AddNode(object value)
        {
            Node node = new Node(value);
            Nodes.Add(node);
            return node;
        }

        // Takes in a Node. If that Node does not exist within the Graph, the Node is added and the method returns true.
        //  If the Node already exists within the graph, the method returns false. 
        // The returned boolean value indicates whether the given Node was added to the Graph. 
        public bool AddNode(Node node)
        {
            if (!Nodes.Contains(node))
            {
                Nodes.Add(node);
                return true;
            }
            else return false;
        }

        // Adds a connection between two Nodes in the Graph. 
        public void AddEdge(Node node1, Node node2)
        {
            if (!Nodes.Contains(node1) || !Nodes.Contains(node2))
                throw new ArgumentOutOfRangeException("The Graph must already contain both nodes to add a connection between them.");

            node1.Adjacencies.Add(new Tuple<Node, int?>(node2, null));
            node2.Adjacencies.Add(new Tuple<Node, int?>(node1, null));
        }

        // Gives a node a new connection to itself.
        public void AddEdge(Node node)
        {
            if (!Nodes.Contains(node)) throw new ArgumentOutOfRangeException("Given Node does not exist in this Graph.");

            node.Adjacencies.Add(new Tuple<Node, int?>(node, null));
        }

        // Gives a node a new connection to itself with the given weight.
        public void AddEdge(Node node, int weight)
        {
            if (!Nodes.Contains(node)) throw new ArgumentOutOfRangeException("Given Node does not exist in this Graph.");

            node.Adjacencies.Add(new Tuple<Node, int?>(node, weight));
        }

        // Adds a connection between two Nodes in the Graph with the given weight.
        public void AddEdge(Node node1, Node node2, int? weight)
        {
            if (!Nodes.Contains(node1) || !Nodes.Contains(node2))
                throw new ArgumentOutOfRangeException("The Graph must already contain both nodes to add a connection between them.");

            node1.Adjacencies.Add(new Tuple<Node, int?>(node2, weight));
            node2.Adjacencies.Add(new Tuple<Node, int?>(node1, weight));
        }

        // Returns all Nodes in the Graph.
        public IEnumerable<Node> GetNodes()
        {
            return Nodes.Count > 0 ? Nodes : null;
        }

        // Takes in a given Node; if that Node exists within the Graph, returns all Nodes that the given Node is connected to
        //  within the Graph, paired with the weight of each connection.
        public IEnumerable<Tuple<Node, int?>> GetNeighbors(Node node)
        {
            if (!Nodes.Contains(node))
                throw new ArgumentOutOfRangeException("The Graph does not contain the given Node.");

            return node.Adjacencies;
        }

        // Returns the total number of Nodes contained in the Graph.
        public int Size()
        {
            return Nodes.Count;
        }
    }
}
