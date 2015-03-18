using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class CheckBinarySearchTree
    {
        public static int CheckBST(TreeNode root)
        {
            if(root.Left == null && root.Right == null)
            {
                return root.Value;
            }
            else if(root.Left == null)
            {
                var right = CheckBST(root.Right);
                if(right==-1)
                {
                    return -1;
                }

                return root.Value < right? right : -1;
            }
            else if(root.Right == null)
            {
                var left = CheckBST(root.Left);
                if(left == -1)
                {
                    return left;
                }

                return root.Value >= left? root.Value : -1;
            }
            else
            {
                var left = CheckBST(root.Left);
                if(left == -1)
                {
                    return left;
                }

                var right = CheckBST(root.Right);
                if(right==-1)
                {
                    return -1;
                }

                return (root.Value >= left) && (root.Value < right) ? right : -1;
            }
        }
    }
}
