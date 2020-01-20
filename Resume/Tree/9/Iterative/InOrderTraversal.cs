using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree._9.Iterative
{
    public class InOrderTraversal
    {

        public static void Traverse(Interview.Tree.BinarySearchTreeImplementation.TreeNode root)
        {
            var current = root;
            Stack<Interview.Tree.BinarySearchTreeImplementation.TreeNode> printNodes = new Stack<BinarySearchTreeImplementation.TreeNode>();

            while (current != null || printNodes.Count != 0)
            {
                while (current != null)
                {
                    printNodes.Push(current);
                    current = current.LeftNode;
                }

                current = printNodes.Pop();
                Console.Write(current.Data + " ");
                current = current.RightNode;
            }
        }
    }
}
