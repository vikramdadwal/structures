
using Interview.Tree.BinarySearchTreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree._28
{
    public class MaxDepthOfBinaryTree
    {
        public static int FindMaxDepthOfBinaryTree(TreeNode treeNode)
        {
            if(treeNode == null)
            {
                return 0;
            }

            int left = FindMaxDepthOfBinaryTree(treeNode.LeftNode);
            int right = FindMaxDepthOfBinaryTree(treeNode.RightNode);

            return Math.Max(left, right) + 1;
        }
    }
}
