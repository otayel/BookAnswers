using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGraphRoute();
        }

        static void TestBalancedTree()
        {
            CheckBalancedTree balancedTree = new CheckBalancedTree();
        }

        static void TestGraphRoute()
        {
            GraphNode<int> node8 = new GraphNode<int>(8);
            GraphNode<int> node4 = new GraphNode<int>(4);
            node4.AddNode(node8);

            GraphNode<int> node3 = new GraphNode<int>(3);
            node3.AddNode(node4);

            GraphNode<int> node5 = new GraphNode<int>(5);
            node5.AddNode(node4);

            GraphNode<int> node6 = new GraphNode<int>(6);
            node6.AddNode(node5);

            GraphNode<int> node2 = new GraphNode<int>(2);
            //node2.AddNode(node3);
            node2.AddNode(node6);

            GraphNode<int> node7 = new GraphNode<int>(7);
            node7.AddNode(node5);

            GraphNode<int> node1 = new GraphNode<int>(1);
            node1.AddNode(node2);
            node1.AddNode(node7);

            Console.WriteLine(new GraphRoute().CheckIfPathExists(node1, node3));
        }
    }
}
