using Interview.Tree._9.Iterative;
using Interview.Tree.BinarySearchTreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree._13
{
    public static class KthSmallElementBST
    {
        public static void PrintElement(Interview.Tree.BinarySearchTreeImplementation.TreeNode root, int k)
        {
            int[] nums = new int[2];

            InOrderTraversal(root, nums, k);

            Console.WriteLine($"Smallest {k}th Element is :: {nums[1]}");
        }

        private static void InOrderTraversal(BinarySearchTreeImplementation.TreeNode root, int[] nums, int k)
        {
            if(root == null)
            {
                return;
            }

            InOrderTraversal(root.LeftNode, nums, k);

            if(++nums[0] == k)
            {
                nums[1] = root.Data;
                return;
            }

            InOrderTraversal(root.RightNode, nums, k);
        }
    }
}
