using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;
using System.Linq;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void ContainsAfterAdded()
        {
            Graph graph = new Graph();
            Node node = new Node(1);
            graph.AddNode(node);
            Assert.Contains(node, graph.Nodes);
        }

        [Fact]
        public void EdgeAdded()
        {
            Graph graph = new Graph();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            graph.AddNode(node1);
            graph.AddNode(node2);
            graph.AddEdge(node1, node2);
            Assert.NotNull(node1.Adjacencies);
        }

        [Fact]
        public void AllNodesReturned()
        {
            Graph graph = new Graph();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            graph.AddNode(node1);
            graph.AddNode(node2);
            IEnumerable<Node> nodes = graph.GetNodes();
            Assert.True(nodes.Count() == 2);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(99)]
        public void AllNeighborsReturned(int neighbors)
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode(0);
            graph.AddNode("Extra node for funsies");

            for (int i = 1; i <= neighbors; i++)
            {
                Node nuNeighbor = graph.AddNode(i);
                graph.AddEdge(node1, nuNeighbor);
            }
            
            Assert.Equal(neighbors, node1.Adjacencies.Count);
        }

        [Fact]
        public void RightNeighborsReturned()
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode(1);
            Node node2 = graph.AddNode(2);
            Node node3 = graph.AddNode(3);
            Node node4 = graph.AddNode(4);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node2, node4);

            List<Node> adjacents = node1.Adjacencies.Select(adj => adj.Item1).ToList();

            Assert.True(adjacents.Contains(node2) && adjacents.Contains(node3));
        }

        [Fact]
        public void NoWrongNeighbors()
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode(1);
            Node node2 = graph.AddNode(2);
            Node node3 = graph.AddNode(3);
            Node node4 = graph.AddNode(4);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node2, node4);

            List<Node> adjacents = node1.Adjacencies.Select(adj => adj.Item1).ToList();

            Assert.DoesNotContain(node4, adjacents);
        }

        [Theory]
        [InlineData(null,null)]
        [InlineData(4,5)]
        public void HaveWeights(int? weight1, int? weight2)
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode(1);
            Node node2 = graph.AddNode(2);
            Node node3 = graph.AddNode(3);


            graph.AddEdge(node1, node2, weight1);
            graph.AddEdge(node1, node3, weight2);

            List<int?> weights = node1.Adjacencies.Select(adj => adj.Item2).ToList();
            Assert.True(weights.Contains(weight1) && weights.Contains(weight2));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(1337)]
        public void CanCount(int nodeCount)
        {
            Graph graph = new Graph();
            for (int i = 0; i < nodeCount; i++)
                graph.AddNode(i);

            Assert.Equal(nodeCount, graph.Size());
        }

        [Fact]
        public void OneNodeGetsGot()
        {
            Graph graph = new Graph();
            Node node = graph.AddNode(1);

            IEnumerable<Node> nodes = graph.GetNodes();
            Assert.Contains(node, nodes);
        }

        [Fact]
        public void NodesOnlyTrueFriendIsHimself()
        {
            Graph graph = new Graph();
            Node node = graph.AddNode(1);
            graph.AddEdge(node);

            Node adjNode = graph.GetNeighbors(node).Select(adj => adj.Item1).FirstOrDefault();

            Assert.Equal(node, adjNode);
        }

        [Fact]
        public void NoNodes()
        {
            Graph graph = new Graph();
            Assert.Null(graph.GetNodes());
        }

    }
}
