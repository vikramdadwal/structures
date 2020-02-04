using Interview.Tree.BinarySearchTreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree._1
{
    public static class SortedArrayToBalancedTree
    {
        public static OldTreeNode Convert(int[] sortedArray)
        {
            var binaryTree = CreateBinaryTree(sortedArray, 0, sortedArray.Length - 1);
            TreeMethods.InOrderTraversal(binaryTree);
            return binaryTree;
        }

        private static OldTreeNode CreateBinaryTree(int[] sortedArray, int start, int end)
        {
            if(start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;

            var root = new OldTreeNode(sortedArray[mid]);
            root.Left = CreateBinaryTree(sortedArray, start, mid - 1);
            root.Right = CreateBinaryTree(sortedArray, mid + 1, end);

            return root;
        }
    }
}
