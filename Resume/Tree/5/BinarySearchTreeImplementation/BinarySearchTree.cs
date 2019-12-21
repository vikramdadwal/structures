using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Interview.Tree.BinarySearchTreeImplementation
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {

        }

        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
            }
            else
            {
                root.Insert(data);
            }
        }

        public void InOrderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("No nodes to print");
            }
            else
            {
                root.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("No nodes to print");
            }
            else
            {
                root.PreOrderTraversal();
            }
        }

        public void POstOrderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("No nodes to print");
            }
            else
            {
                root.PostOrderTraversal();
            }
        }

        public TreeNode Find(int data)
        {
            if(root == null)
            {
                return null;
            }

            return root.FindWithCurrentNodePointer(data);
        }


        public void Remove(int data)
        {
            bool IsLeftNode = false;
            TreeNode nodeToDelete = root;
            TreeNode ParentNode = root;

            while(nodeToDelete != null && nodeToDelete.Data != data)
            {
                ParentNode = nodeToDelete;

                if(data > nodeToDelete.Data)
                {
                    nodeToDelete = nodeToDelete.RightNode;
                    IsLeftNode = false;
                }
                else
                {
                    nodeToDelete = nodeToDelete.LeftNode;
                    IsLeftNode = true;
                }
            }

            if(nodeToDelete == null)
            {
                return;
            }


            // Case 1 Leaf Node
            if(nodeToDelete.LeftNode == null && nodeToDelete.RightNode == null)
            {
                if(nodeToDelete == root)
                {
                    root = null;
                }
                else
                {
                    if(IsLeftNode)
                    {
                        ParentNode.LeftNode = null;
                    }
                    else
                    {
                        ParentNode.RightNode = null;
                    }
                }
            }
            else if(nodeToDelete.RightNode == null)   // Case 2 if one child n0de
            {
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.LeftNode;
                }
                else
                {
                    if (IsLeftNode)
                    {
                        ParentNode.LeftNode = nodeToDelete.LeftNode;
                    }
                    else
                    {
                        ParentNode.RightNode = nodeToDelete.LeftNode;
                    }
                }
            }
            else if(nodeToDelete.LeftNode == null)  // Case 2 if one child n0de
            {
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.RightNode;
                }
                else
                {
                    if(IsLeftNode)
                    {
                        ParentNode.LeftNode = nodeToDelete.RightNode;
                    }
                    else
                    {
                        ParentNode.RightNode = nodeToDelete.RightNode;
                    }
                }
            }
            else  //Case 3 if 2 child nodes
            {
                TreeNode successor = GetSuccessor(nodeToDelete);

                if(root == nodeToDelete)
                {
                    root = successor;
                }
                else if(IsLeftNode)
                {
                    ParentNode.LeftNode = successor;
                }
                else
                {
                    ParentNode.RightNode = successor;
                }
            }
        }

        private TreeNode GetSuccessor(TreeNode nodeToDelete)
        {
            var SuccesorPArentNode = nodeToDelete;
            var successor = nodeToDelete;
            var currentNode = nodeToDelete;

            while(currentNode != null)
            {
                SuccesorPArentNode = successor;
                successor = currentNode;
                currentNode = currentNode.LeftNode;
            }

            if(successor != nodeToDelete.RightNode)
            {
                SuccesorPArentNode.LeftNode = successor.RightNode;
                successor.RightNode = nodeToDelete.RightNode;
            }

            successor.LeftNode = nodeToDelete.LeftNode;

            return successor;

        }
    }
}
