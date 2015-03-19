using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class CommonAncestor
    {
        public static TreeNode FindLowestCommonAncestor(TreeNode node1, TreeNode node2, TreeNode root)
        {
            if (!IsParent(node1, root) && !IsParent(node2, root))
            {
                return null;
            }

            return FindCommon(node1, node2, root);
        }

        static TreeNode FindCommon(TreeNode node1, TreeNode node2, TreeNode root)
        {
            bool node1OnLeft = IsParent(node1, root.Left);
            bool node2OnLeft = IsParent(node2, root.Left);

            if (node1OnLeft != node2OnLeft)
            {
                return root;
            }
            else if (node1OnLeft && node2OnLeft)
            {
                return FindCommon(node1, node2, root.Left);
            }
            else
            {
                return FindCommon(node1, node2, root.Right);
            }
        }

        //Is node in tree of root or not
        static bool IsParent(TreeNode node, TreeNode root)
        {
            if (root == null || node == null)
            {
                return false;
            }

            if (node.Value == root.Value)
            {
                return true;
            }

            return IsParent(node, root.Left) || IsParent(node, root.Right);
        }
    }
}
