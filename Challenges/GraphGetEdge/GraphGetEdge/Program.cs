
using Graphs.Classes;
using System;
using System.Linq;

namespace GraphGetEdge
{
    public class Program
    {
        static void Main(string[] args)
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

            Tuple<bool, int> derp = GetEdge(new string[] { "Naboo", "Coruscant", "Geonosia", "Endor" }, graph);

            if (derp.Item1 == true)
                Console.WriteLine(derp.Item2);
        }


        /// <summary>
        ///     Takes in an itinerary consisting of a string array of city names, and a Graph, representing different cities and the connecting
        ///       flights offered between them, where the weight of each connection indicates the price.
        ///       
        ///     Checks whether or not the given itinerary is viable with direct flights, and the price of a viable path. Returns a tuple with
        ///       a boolean indicating whether the itinerary is valid and an integer representing the price of a valid flight, or 0 if invalid.
        /// </summary>
        /// <param name="itinerary"> Array of strings representing an itinerary of city names </param>
        /// <param name="connections"> Graph representing cities and the flight connections offered between them </param>
        /// <returns> Tuple, with a boolean indicating whether the itinerary was viable, and an integer representing the price of the flight </returns>
        public static Tuple<bool, int> GetEdge(string[] itinerary, Graph connections)
        {
            Tuple<bool, int> nuffin = new Tuple<bool, int>(false, 0);
            int price = 0;

            if (itinerary == null || connections == null || connections.Nodes == null)
                throw new ArgumentNullException("Null argument passed.");

            if (itinerary.Length > connections.Size() || itinerary.Length < 2) 
                return nuffin;
        
            Node current = connections.Nodes.Where(n => (string)n.Value == itinerary[0])
                                            .FirstOrDefault();

            if (current == null)
                return nuffin;

            for(int i = 1; i < itinerary.Length; i++)
            {
                Tuple<Node, int?> nextFlight = connections.GetNeighbors(current).Where(adj => (string)adj.Item1.Value == itinerary[i])
                                                                                .FirstOrDefault();
                if (nextFlight == null)
                    return nuffin;
                else
                {
                    current = nextFlight.Item1;
                    price += nextFlight.Item2 ?? 0;
                }
            }

            return new Tuple<bool, int>(true, price);
        }
    }

}
