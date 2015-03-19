using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class NextInOrderSuccessor
    {
        public static TreeNode FindNextInOrderSuccessor(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Right != null)
            {
                return LeftMostNode(node.Right);
            }
            else
            {
                TreeNode parent = node.Parent;
                while (parent != null && parent.Right == node)
                {
                    node = node.Parent;
                    parent = node.Parent;
                }

                if(parent == null)
                {
                    return null;
                }
                else
                {
                    return parent;
                }
            }
        }

        private static TreeNode LeftMostNode(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
    }
}
