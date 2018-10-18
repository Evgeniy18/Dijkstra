using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Graph : Dictionary<int, Node>
    {
        public void createNodes(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                this.Add(i, new Node());
            }
        }

        public void createEdges(List<string> strEdges)
        {
            foreach (string str in strEdges)
            {
                string[] splitedEdges = str.Split(',');
                int startNodeNum = Int32.Parse(splitedEdges[0].Trim());
                int endNodeNum = Int32.Parse(splitedEdges[1].Trim());
                int weight = Int32.Parse(splitedEdges[2].Trim());
                this[startNodeNum].edges.Add(new Edge(this[endNodeNum], weight));
            }
        }

        public void runDijkstraAlgorithm(int startNode)
        {
            this[startNode].setMinDists();
        }
    }
}
