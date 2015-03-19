using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class BSTFromSortedArray
    {
        public void ConstructTree(int[] array, int start, int end, ref TreeNode root)
        {
            if (start == end)
            {
                root = new TreeNode()
                {
                    Value = array[start]
                };
                return;
            }
            else if (start > end)
            {
                return;
            }

            int medium = (int)Math.Ceiling(((double)(end + start)) / 2);
            root = new TreeNode()
            {
                Value = array[medium]
            };

            ConstructTree(array, start, medium - 1, ref root.Left);
            ConstructTree(array, medium + 1, end, ref root.Right);
        }
    }

    class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode Parent;
        public int Value;
    }
}
