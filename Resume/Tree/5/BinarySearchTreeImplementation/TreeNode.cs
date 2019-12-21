using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tree.BinarySearchTreeImplementation
{
    public class TreeNode
    {
        public int Data;

        public TreeNode RightNode;

        public TreeNode LeftNode;

        public TreeNode(int data)
        {
            this.Data = data;
        }

        public void Insert(int data)
        {
            if(data >= this.Data)
            {
                if(RightNode == null)
                {
                    RightNode = new TreeNode(data);
                }
                else
                {
                    RightNode.Insert(data);
                }
            }
            else
            {
                if(LeftNode == null)
                {
                    LeftNode = new TreeNode(data);
                }
                else
                {
                    LeftNode.Insert(data);
                }
            }
        }

        /// <summary>
        /// Left->Root->Right
        /// </summary>
        public void InOrderTraversal()
        {
            if(this.LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }

            Console.Write(Data + " ");

            if(RightNode != null)
            {
                RightNode.InOrderTraversal();
            }
        }

        /// <summary>
        /// Root->Left->Right
        /// </summary>
        public void PreOrderTraversal()
        {
            Console.Write(this.Data + " ");

            if(LeftNode != null)
            {
                LeftNode.PreOrderTraversal();
            }

            if(RightNode != null)
            {
                RightNode.PreOrderTraversal();
            }
        }

        /// <summary>
        /// Left->Right->Root
        /// </summary>
        public void PostOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.PostOrderTraversal();
            }

            if (RightNode != null)
            {
                RightNode.PostOrderTraversal();
            }

            Console.Write(this.Data + " ");
        }

        public TreeNode FindWithCurrentNodePointer(int data)
        {
            TreeNode CurrentNode = this;

            while(CurrentNode != null)
            {
                if(data == CurrentNode.Data)
                {
                    return CurrentNode;
                }

                if(data > CurrentNode.Data)
                {
                    CurrentNode = CurrentNode.RightNode;
                }
                else
                {
                    CurrentNode = CurrentNode.LeftNode;
                }
            }

            return null;
        }

    }
}
