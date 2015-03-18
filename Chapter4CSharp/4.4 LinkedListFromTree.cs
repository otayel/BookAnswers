using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class LinkedListFromTree
    {
        public List<Node> CreateLinkedListsFromTree(TreeNode root)
        {
            List<Node> linkedLists = new List<Node>();
            //linkedLists.Add(new Node() { Value = root.Value });

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            Node currentLinkedList = new Node();
            linkedLists.Add(currentLinkedList);
            Queue<TreeNode> nextLevel = new Queue<TreeNode>();
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                currentLinkedList.Value = node.Value;
                if (node.Left != null)
                {
                    nextLevel.Enqueue(node.Left);
                }
                
                if(node.Right != null)
                {
                    nextLevel.Enqueue(node.Right);
                }

                if (queue.Count == 0)
                {
                    while (nextLevel.Count > 0)
                    {
                        queue.Enqueue(nextLevel.Dequeue());
                    }
                    if (queue.Count > 0)
                    {
                        currentLinkedList = new Node();
                        linkedLists.Add(currentLinkedList);
                    }
                }
                else
                {
                    var newNode = new Node();
                    currentLinkedList.Next = newNode;
                    currentLinkedList = newNode;
                }
            }
            return linkedLists;
        }
    }

    class Node
    {
        public Node Next { set; get; }
        public int Value { set; get; }
    }
}
