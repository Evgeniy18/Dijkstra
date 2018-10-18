using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Node
    {
        public int distance = 2000000000;
        public bool visited = false;
        public List<Edge> edges = new List<Edge>();

        public void setMinDists()
        {
            this.distance = 0;
            setNeighboursDists(this);
        }

        void setNeighboursDists(Node node)
        {
            Node nodeWithMinDist = null;
            int minDist = 2000000000;

            node.visited = true;
            foreach (Edge edge in node.edges)
            {
                if (edge.neighbourNode.visited == false)
                {
                    int tempDist = node.distance + edge.weight;
                    if (edge.neighbourNode.distance > tempDist)
                    {
                        edge.neighbourNode.distance = tempDist;
                    }
                    if (edge.neighbourNode.distance <= minDist)
                    {
                        minDist = tempDist;
                        nodeWithMinDist = edge.neighbourNode;
                    }
                }
            }
            if (nodeWithMinDist != null)
            {
                setNeighboursDists(nodeWithMinDist);
            }
        }
    }

    struct Edge
    {
        public Node neighbourNode;
        public int weight;

        public Edge(Node node, int dist)
        {
            this.neighbourNode = node;
            this.weight = dist;
        }
    }

}
