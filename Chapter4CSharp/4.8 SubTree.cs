using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class SubTree
    {
        public static bool IsSubTree(TreeNode rootSmall1, TreeNode rootLarge2)
        {
            string inOrder1 = InOrder(rootSmall1);
            string inOrder2 = InOrder(rootLarge2);
            string preOrder1 = PreOrder(rootSmall1);
            string preOrder2 = PreOrder(rootLarge2);

            return inOrder2.Contains(inOrder1) && preOrder2.Contains(preOrder1);
        }

        static string InOrder(TreeNode root)
        {
            StringBuilder s = new StringBuilder();
            if(root.Left == null)
            {
                s.Append("N");
            }
            else
            {
                s.Append(InOrder(root.Left));
            }

            s.Append(root.Value);

            if (root.Right == null)
            {
                s.Append("N");
            }
            else
            {
                s.Append(InOrder(root.Right));
            }

            return s.ToString();
        }

        static string PreOrder(TreeNode root)
        {
            StringBuilder s = new StringBuilder();

            s.Append(root.Value);

            if (root.Left == null)
            {
                s.Append("N");
            }
            else
            {
                s.Append(PreOrder(root.Left));
            }

            if (root.Right == null)
            {
                s.Append("N");
            }
            else
            {
                s.Append(PreOrder(root.Right));
            }

            return s.ToString();
        }
    }
}
