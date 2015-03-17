using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4CSharp
{
    class CheckBalancedTree
    {
        public CheckBalancedTree()
        {
            TreeNode<int> level4_1 = new TreeNode<int>();
            TreeNode<int> level4_2 = new TreeNode<int>();

            TreeNode<int> level3_1 = new TreeNode<int>() { Left = level4_1 };
            TreeNode<int> level3_2 = new TreeNode<int>() { Right = level4_2 };
            TreeNode<int> level3_3 = new TreeNode<int>();
            TreeNode<int> level3_4 = new TreeNode<int>();

            TreeNode<int> level2_1 = new TreeNode<int>() { Left = level3_1, Right = level3_4 };
            TreeNode<int> level2_2 = new TreeNode<int>() { Left = level3_2, Right = level3_3 };

            TreeNode<int> level1_1 = new TreeNode<int>() { Left = level2_1, Right = level2_2 };

            Console.WriteLine(Check(level1_1) > -1 ? "Balanced" : "Unbalacned");
        }

        public int Check(TreeNode<int> TreeNode)
        {
            if (TreeNode == null)
            {
                return 0;
            }
            else
            {
                int leftSize = Check(TreeNode.Left);
                if (leftSize == -1)
                {
                    return -1;
                }

                int righSize = Check(TreeNode.Right);
                if (righSize == -1)
                {
                    return -1;
                }

                if (Math.Abs(leftSize - righSize) > 1)
                {
                    return -1;
                }
                else
                {
                    return Math.Max(leftSize, righSize) + 1;
                }
            }
        }
    }

    class TreeNode<T>
    {
        public T Value { set; get; }
        public TreeNode<T> Left { set; get; }
        public TreeNode<T> Right { set; get; }
    }
}
