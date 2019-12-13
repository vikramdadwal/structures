using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interview
{
    /// <summary>
    /// https://github.com/mission-peace/interview/blob/master/src/com/interview/tree/TreeTraversals.java
    /// https://github.com/mission-peace/interview/blob/master/src/com/interview/tree/BSTSearch.java
    /// 
    /// </summary>
    public class TreeMethods
    {
        public static void FindMininBST(TreeNode header)
        {
            var current = header;
            TreeNode previous = null;

            while (current != null)
            {
                previous = current;
                current = current.Left;
            }

            Console.WriteLine(previous.Value);
        }

        public static void FindMaxinBST(TreeNode header)
        {
            var current = header;
            TreeNode previous = null;
            while (current != null)
            {
                previous = current;
                current = current.Right;
            }

            Console.WriteLine(previous.Value);
        }

        public static int FindHeight(TreeNode header)
        {
            // Height of tree –The height of a tree is the number of edges on the longest downward path between the root and a leaf.
            //Height of node –The height of a node is the number of edges on the longest downward path between that node and a leaf.
            ///Depth –The depth of a node is the number of edges from the node to the tree's root node.

            if (header == null)
            {
                return -1;
            }

            return Math.Max(FindHeight(header.Left), FindHeight(header.Right)) + 1;

        }

        #region > Travesal <

        public static void BFT_LevelOrderTraversal(TreeNode header)
        {
            if (header == null)
            {
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(header);

            while (queue.Any())
            {
                TreeNode current = queue.Dequeue();
                Console.WriteLine(current.Value);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

        }

        #region > Recursive <

        public static void PreOrderTraversal(TreeNode header)
        {
            // {root} -> left -> right
            if (header == null) return;

            Console.WriteLine(header.Value);

            PreOrderTraversal(header.Left);
            PreOrderTraversal(header.Right);

        }

        public static void InOrderTraversal(TreeNode header)
        {
            // left --> {root} -> right
            if (header == null) return;

            InOrderTraversal(header.Left);
            Console.WriteLine(header.Value);
            InOrderTraversal(header.Right);

        }

        public static void PostOrderTraversal(TreeNode header)
        {
            // left --> right --> {root}
            if (header == null) return;

            PostOrderTraversal(header.Left);
            PostOrderTraversal(header.Right);
            Console.WriteLine(header.Value);

        }


        #endregion

        #region > Iterative <

        // left --> {root} -> right
        public static void InOrderIterative(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(true)
            {
                if(root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }
                else
                {
                    if (!stack.Any())
                        break;

                    root = stack.Pop();
                    Console.WriteLine(root.Value);
                    root = root.Right;
                }
            }
        }

        // {root} -> left -> right
        public static void PreOrderIterative(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);
            while(stack.Any())
            {
                root = stack.Pop();
                Console.WriteLine(root.Value);

                if (root.Right != null)
                    stack.Push(root.Right);

                if (root.Left != null)
                    stack.Push(root.Left);
            }
        }


        // left --> right --> {root}
        public static void PostOrderIterative(TreeNode root)
        {
            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();

            stack1.Push(root);
            while (stack1.Any())
            {
                root = stack1.Pop();
                Console.WriteLine(root.Value);

                if (root.Left != null)
                    stack1.Push(root.Left);

                if (root.Right != null)
                    stack1.Push(root.Right);

                stack2.Push(root);
            }

            while(stack2.Any())
            {
                Console.WriteLine(stack2.Pop().Value);
            }
        }


        #endregion

        #endregion
        
        public static void BT_is_BST(TreeNode header)
        {
            isBSTUtil(header, int.MinValue, int.MaxValue);

        }

        public static bool isBSTUtil(TreeNode root, int min, int max)
        {
            if (root == null) return true;

            if (root.Value > min && root.Value < max
                && isBSTUtil(root.Left, min, root.Value)
                && isBSTUtil(root.Right, root.Value, max))
                return true;

            return false;
        }

        public static bool IsBSTUsingInOrderTraversal(TreeNode root, TreeNode previous = null)
        {
            if (root != null)
            {

                if (IsBSTUsingInOrderTraversal(root.Left, previous) == false)
                    return false;

                if (previous != null && root.Value <= previous.Value)
                    return false;

                previous = root;

                return IsBSTUsingInOrderTraversal(root.Right, previous);

            }

            return true;
        }

        public static TreeNode DeleteNode(TreeNode root, int value)
        {
            if (root == null) return root;

            if (root.Value > value)
            {
                root.Left = DeleteNode(root.Left, value);
            }
            else if (root.Value < value)
            {
                root.Right = DeleteNode(root.Right, value);
            }
            else
            {
                // Case 1 :  No child (leaf node)
                if (root.Left == null && root.Right == null)
                {
                    root = null;

                }
                //Case 2 : One child (iether left or right)
                else if (root.Left == null)
                {
                    root = root.Right;

                }
                else if (root.Right == null)
                {
                    root = root.Left;

                }
                //Case 3:  Two child
                else
                {
                    TreeNode temp = FindMin(root.Right);  // Find min in the right subtree
                    root.Value = temp.Value; // Copy the value in targetted node
                    root.Right = DeleteNode(root.Right, temp.Value); // Delete duplicate from the right subtree
                }
            }

            return root;
        }

        public static TreeNode FindMin(TreeNode header)
        {
            var current = header;
            TreeNode previous = null;

            while (current != null)
            {
                previous = current;
                current = current.Left;
            }

            return previous;
        }

        public static bool SameTree(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 == null || tree2 == null)
                return false;

            return (tree1.Value == tree2.Value && SameTree(tree1.Left, tree2.Left) && SameTree(tree1.Right, tree2.Right));

        }


        #region > In Order succesor etc.. < 

        /// <summary>
        ///                8
        ///             4       10
        ///         3       6       18
        /// 
        /// in order = 3, 4, 6, 8, 10, 18
        /// in order succesor of 6 is 8
        /// 
        /// Case 1: Node has right subtree. => Go to the left modost node i.e. find the min in the right sub tree
        /// Case 2: Node has NO right subtree => Go to the nearest ancestor for which the given node lies in the left subtree.
        /// In above tree if n = 3 then ancestor = 4 (as 3 lies in the left side of this node)
        /// for n = 6 then ancestor = 8 (as 6 lies in the left of 8 [ n = 6 is riht subtree of 4)
        /// 
        /// NOTE::: If we going from left subtree to upward then the node will not be yet visited in the in order where as if going from 
        /// right subtree the node is already visited
        ///  
        /// Big O (H)   h is hight of the tree
        /// </summary>
        /// <param name="root"></param>
        public static TreeNode FindInorderSuccesor(TreeNode root, int data)
        {
            if(root == null)
            {
                return null;
            }

            TreeNode currentNode = FindNode(root, data); // First find the node for which the successor needs to be find

            if (currentNode == null) return null;

            if(currentNode.Right != null) // For predesor check left
            {
                return FindMinNodeinRight(currentNode.Right);  // Case 1

                // For Presedor
                // return FindMaxInLeft(currentNode.Left)
            }
            else
            {
                // Case2
                TreeNode succesor = null;
                TreeNode ancesstor = root;

                while(ancesstor != currentNode)
                {
                    // keep on finding the nearest ancetor for which the node is in the left side
                    if (ancesstor.Value > currentNode.Value) 
                    {
                        succesor = ancesstor;              
                        ancesstor = ancesstor.Left;
                    }
                    else
                    {
                        ancesstor = ancesstor.Right;
                    }


                    /*
                    // For presedor
                    // keep on finding the nearest ancetor for which the node is in the right side
                    if (ancesstor.Value < currentNode.Value) 
                    {
                        succesor = ancesstor;              
                        ancesstor = ancesstor.Right;
                    }
                    else
                    {
                        ancesstor = ancesstor.left;
                    }




                    */
                }

                return succesor;
            }

        } 

        private static TreeNode FindMinNodeinRight(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        private static TreeNode FindNode(TreeNode root, int data)
        {
            TreeNode bresult = null;

            if (root == null)
            {
                return null;

            }

            if (root.Value == data)
                return root;
            else if(root.Value > data)
            {
                return FindNode(root.Left, data);
            }
            else if(root.Value < data)
            {
                return FindNode(root.Right, data);
            }

            return bresult;
        }

        #endregion

        #region > Common Ancestor For BST and BT <

        public static TreeNode CommonAncestorBST(TreeNode root, int a, int b)
        {
            if (root == null) return null;

            if(root.Value > a && root.Value > b)
            {
                return CommonAncestorBST(root.Left, a, b);
            }
            else if (root.Value < a && root.Value < b)
            {
                return CommonAncestorBST(root.Right, a, b);
            }
            else
            {
                return root;
            }

        }

        public static TreeNode CommonAncestorBT(TreeNode root, TreeNode a, TreeNode b)
        {
            var res = CommonAncestorHelperBT(root, a, b);
            if (res.isAncestor) return res.Node;
            return null;
        }
        public static Result CommonAncestorHelperBT(TreeNode root, TreeNode a, TreeNode b)
        {
            if (root == null)
                return new Result(null, false);

            if(root == a && root == b)
            {
                return new Result(root, true);
            }

            Result rleft = CommonAncestorHelperBT(root.Left, a, b);

            if(rleft.isAncestor)
            {
                return rleft;
            }

            Result rRight = CommonAncestorHelperBT(root.Right, a, b);
            if(rRight.isAncestor)
            {
                return rRight;
            }

            if(rleft.Node != null && rRight.Node != null)
            {
                return new Result(root, true); // This is my common ancestor
            }
            else if(root == a || root == b)
            {
                //if we are currently at a or b and also one of these node is in the subtree then this is and ancestor
                bool isAncestor = rleft.Node != null || rRight.Node != null;
                return new Result(root, isAncestor);
            }
            else
            {
                return new Result(rleft.Node != null ? rleft.Node : rRight.Node, false);
            }

        }

        #endregion

        #region > Is Balanced Tree < 

        public static int getheight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(getheight(node.Left), getheight(node.Right)) + 1;
        }

        //>>>>>> O( n log n)
        public static bool IsBalanced(TreeNode node)
        {
            if (node == null) return true;

            int heightDiff = getheight(node.Left) - getheight(node.Right);

            if (heightDiff > 1)
            {
                return false;
            }
            else
            {
                return IsBalanced(node.Left) && IsBalanced(node.Right);
            }

        }


        //>>>>>> O(n) // best approach
        public static bool IsBalanaced(TreeNode node)
        {
            if (validateHeight(node) == -1)
            {
                return false;
            }
            else
                return true;
        }

        public static int validateHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = validateHeight(node.Left);
            if (leftHeight == -1)
            {
                return -1;
            }

            int rightHeight = validateHeight(node.Right);
            if (rightHeight == -1)
            {
                return -1;
            }

            int diff = leftHeight - rightHeight;
            if(diff > 1)
            {
                return -1;
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }


        #endregion

        #region > Number of paths with = sum <

        public static int CountPathsWithSum(TreeNode node, int sum)
        {
            if (node == null) return 0;

            int rootPath = CountPathFromNode(node, sum, 0);

            int leftPaths = CountPathsWithSum(node.Left, sum);
            int rightPaths = CountPathsWithSum(node.Right, sum);

            return rootPath + leftPaths + rightPaths;

        }

        private static int CountPathFromNode(TreeNode node, int sum, int currentSum)
        {
            if (node == null) return 0;

            currentSum += node.Value;

            int pathcount = 0;

            if (currentSum == sum) pathcount++;

            pathcount += CountPathFromNode(node.Left, sum, currentSum);
            pathcount += CountPathFromNode(node.Right, sum, currentSum);

            return pathcount;


        }

        #endregion

        #region > T2 is subtree of T1 <

        /// <summary>
        /// Find if b is a subtree of a
        /// 
        /// Big O (n m)  n is number of node in T1 and m is nodes in T2
        /// </summary>
        /// <param name="T1"></param>
        /// <param name="T2"></param>
        /// <returns></returns>
        public static bool IsSubtree(TreeNode T1, TreeNode T2)
        {
            if (T2 == null)
                return true;

            return Subtree(T1, T2);
        }

        private static bool Subtree(TreeNode T1, TreeNode T2)
        {
            if (T1 == null) return false;  //reached end of tree a but b is not found

            else if(T1.Value == T2.Value && SameSubTree(T1, T2)) // b root node is matched with a node
            {
                return true;
            }

            return Subtree(T1.Left, T2) || Subtree(T1.Right, T2); //Continue traversing-
        }

        private static bool SameSubTree(TreeNode T1, TreeNode T2)
        {
            if (T1 == null && T2 == null) // both reached end of traversal
                return true;

            if(T1 == null || T2 == null) // either one of reched to end then that is not a match
            {
                return false;
            }

            return (T1.Value == T2.Value) && SameSubTree(T1.Left, T2.Left) && SameSubTree(T1.Right, T2.Right);
        }


        #endregion

        #region > Count nodes that are in a given range <

        public static int getcount(TreeNode root, int min, int max)
        {
            if (root == null) return 0;

            if (root.Value == min && root.Value == max)
                return 1;

            if(root.Value >= min && root.Value <= max)
            {
                return 1 + getcount(root.Left, min, max) + getcount(root.Right, min, max);
            }
            else if(root.Value < min)
            {
                return getcount(root.Right, min, max);
            }
            else
            {
                return getcount(root.Left, min, max);
            }
        }

        #endregion
    }

    public class Result
    {
        public bool isAncestor;
        public TreeNode Node;

        public Result(TreeNode node, bool isAncestor)
        {
            this.isAncestor = isAncestor;
            this.Node = node;
        }
             
    }
}
