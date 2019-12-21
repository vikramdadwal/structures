using System;

namespace Interview.Tree.BinarySearchTreeImplementation
{
    public static class MainClass
    {
        public static void Run()
        {
            var binarySearchTree = new BinarySearchTree();

            binarySearchTree.Insert(55);
            binarySearchTree.Insert(99);
            binarySearchTree.Insert(89);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(67);
            binarySearchTree.Insert(94);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(44);
            binarySearchTree.Insert(11);

            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binarySearchTree.InOrderTraversal();

            Console.WriteLine();

            Console.WriteLine("Pre Order Traversal (Root->Left->Right)");
            binarySearchTree.PreOrderTraversal();

            Console.WriteLine();

            Console.WriteLine("POst Order Traversal (Left->Right->Root)");
            binarySearchTree.POstOrderTraversal();


            Console.WriteLine();

            Console.WriteLine("Find the value without Recursion i.e. using current pointer");
            var node = binarySearchTree.Find(44);  //O(Log n)

            Console.WriteLine($"Found the following value:: { node?.Data }");

        }
    }
}
