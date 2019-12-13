using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class BinaryTree
    {

        public TreeNode _head;
        int count = 0;

        public void Add(int value)
        {
            if (_head == null)
            {
                _head = new TreeNode(value);
            }
            else
            {
                AddTo(_head, value);
            }

            count++;
        }

        private void AddTo(TreeNode node, int val)
        {
            if (val < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(val);
                }
                else
                {
                    AddTo(node.Left, val);
                }
            }
            else if (val >= node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(val);
                }
                else
                {
                    AddTo(node.Right, val);
                }
            }
        }
    }
}
