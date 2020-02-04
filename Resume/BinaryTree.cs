using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class BinaryTree
    {

        public OldTreeNode _head;
        int count = 0;

        public void Add(int value)
        {
            if (_head == null)
            {
                _head = new OldTreeNode(value);
            }
            else
            {
                AddTo(_head, value);
            }

            count++;
        }

        private void AddTo(OldTreeNode node, int val)
        {
            if (val < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new OldTreeNode(val);
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
                    node.Right = new OldTreeNode(val);
                }
                else
                {
                    AddTo(node.Right, val);
                }
            }
        }
    }
}
