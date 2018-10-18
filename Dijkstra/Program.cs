using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodesCount = 6; //количество вершин
            int startNode = 1; //номер начальной вершины
            List<string> strEdges = new List<string>{
                //"Номер_начальной_вершины, номер_конечной_вершины, вес_связи",
                "1, 2, 7",
                "1, 3, 9",
                "1, 6, 14",
                "2, 1, 7",
                "2, 3, 10",
                "2, 4, 15",
                "3, 1, 9",
                "3, 2, 10",
                "3, 4, 11",
                "3, 6, 2",
                "4, 2, 15",
                "4, 3, 11",
                "4, 5, 6",
                "5, 4, 6",
                "5, 6, 9",
                "6, 1, 14",
                "6, 3, 2",
                "6, 5, 9"
            };

            Graph graph = new Graph();

            graph.createNodes(nodesCount);

            graph.createEdges(strEdges);

            graph.runDijkstraAlgorithm(startNode);

            foreach (KeyValuePair<int, Node> node in graph)
            {
                Console.WriteLine("{0} - {1}", node.Key, node.Value.distance);
            }
            Console.Read();
        }
    }
}
