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
            TestCheckBST();
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

        static void TestBSTFromSortedArray()
        {
            TreeNode root = new TreeNode();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            new BSTFromSortedArray().ConstructTree(array, 0, array.Length - 1, ref root);
            return;
        }

        static void TestLinkedListFromTree()
        {
            TreeNode root = new TreeNode();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            new BSTFromSortedArray().ConstructTree(array, 0, array.Length - 1, ref root);
            var list = new LinkedListFromTree().CreateLinkedListsFromTree(root);
        }

        static void TestCheckBST()
        {
            TreeNode root = new TreeNode();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 11, 9, 10 };
            new BSTFromSortedArray().ConstructTree(array, 0, array.Length - 1, ref root);
            Console.WriteLine(CheckBinarySearchTree.CheckBST(root) != -1 ? "Is BST" : "Isn't BST");
        }
    }
}
