using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class GraphRoute
    {
        public bool CheckIfPathExists(GraphNode<int> sourceNode, GraphNode<int> destinationNode)
        {
            Queue<GraphNode<int>> queue = new Queue<GraphNode<int>>();

            if (sourceNode == null || destinationNode == null)
            {
                return false;
            }
            else
            {
                if (sourceNode.Value == destinationNode.Value)
                {
                    return true;
                }
                else
                {
                    sourceNode.Visited = true;
                    queue.Enqueue(sourceNode);
                    while (queue.Count > 0)
                    {
                        var node = queue.Dequeue();
                        foreach (GraphNode<int> neighbor in node.Nodes)
                        {
                            if (!neighbor.Visited)
                            {
                                if (neighbor.Value == destinationNode.Value)
                                {
                                    return true;
                                }
                                else
                                {
                                    neighbor.Visited = true;
                                    queue.Enqueue(neighbor);
                                }
                            }
                        }
                    }

                    return false;
                }
            }
        }
    }

    class GraphNode<T>
    {
        public List<GraphNode<T>> Nodes { get { return nodes; } }
        public T Value { get { return this.value; } }

        public bool Visited { set { this.visited = value; } get { return this.visited; } }

        T value;
        List<GraphNode<T>> nodes;
        bool visited;

        public GraphNode(T value)
        {
            this.value = value;
            this.visited = false;
            nodes = new List<GraphNode<T>>();
        }

        public void AddNode(GraphNode<T> node)
        {
            this.nodes.Add(node);
        }


    }
}
