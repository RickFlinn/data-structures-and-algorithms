using GraphGetEdge;
using Graphs.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TheRightPrice()
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode("Naboo");
            Node node2 = graph.AddNode("Kamino");
            Node node3 = graph.AddNode("Coruscant");
            Node node4 = graph.AddNode("Geonosia");
            Node node5 = graph.AddNode("Tatooine");
            Node node6 = graph.AddNode("Endor");

            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node1, node3, 21);
            graph.AddEdge(node3, node2, 50);
            graph.AddEdge(node3, node4, 201);
            graph.AddEdge(node4, node5, 20);
            graph.AddEdge(node4, node6, 41);

            Tuple<bool, int> derp = Program.GetEdge(new string[] { "Naboo", "Coruscant", "Geonosia", "Endor" }, graph);
            Assert.Equal(263, derp.Item2);
        }

        [Fact]
        public void NonDirectFails()
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode("Naboo");
            Node node2 = graph.AddNode("Kamino");
            Node node3 = graph.AddNode("Coruscant");
            Node node4 = graph.AddNode("Geonosia");
            Node node5 = graph.AddNode("Tatooine");
            Node node6 = graph.AddNode("Endor");

            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node3, node2, 50);
            graph.AddEdge(node3, node4, 201);
            graph.AddEdge(node4, node5, 20);
            graph.AddEdge(node4, node6, 41);

            Tuple<bool, int> derp = Program.GetEdge(new string[] { "Naboo", "Coruscant", "Geonosia", "Endor" }, graph);
            Assert.False(derp.Item1);
        }

        [Fact]
        public void NoMatchingItemFails()
        {
            Graph graph = new Graph();
            Node node1 = graph.AddNode("Naboo");
            Node node2 = graph.AddNode("Kamino");
            Node node3 = graph.AddNode("Coruscant");
            Node node4 = graph.AddNode("Geonosia");
            Node node5 = graph.AddNode("Tatooine");
            Node node6 = graph.AddNode("Endor");

            graph.AddEdge(node1, node2, 100);
            graph.AddEdge(node1, node3, 21);
            graph.AddEdge(node3, node2, 50);
            graph.AddEdge(node3, node4, 201);
            graph.AddEdge(node4, node5, 20);
            graph.AddEdge(node4, node6, 41);

            Tuple<bool, int> derp = Program.GetEdge(new string[] { "Naboo", "Coruscant", "Derplandia", "Endor" }, graph);
            Assert.False(derp.Item1);
        }
    }
}
