using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class OldTreeNode
    {
        public int Value { get; set; }
        public OldTreeNode Left { get; set; }
        public OldTreeNode Right { get; set; }
        public OldTreeNode(int val)
        {
            this.Value = val;
        }
    }
}
