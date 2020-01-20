using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree._9.Recursive
{
    public class InOrderTraversal
    {
        public static void Traverse(Interview.Tree.BinarySearchTreeImplementation.TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            Traverse(root.LeftNode);
            Console.Write(root.Data + " ");
            Traverse(root.RightNode);
        }
    }
}
