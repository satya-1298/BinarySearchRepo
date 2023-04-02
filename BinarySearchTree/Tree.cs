using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }
            Node newnode = new Node();
            newnode.Data = value;
            if (this.Root == null)
            {
                this.Root = newnode;

            }
            else
            {
                if (value < before.Data)
                {
                    before.LeftNode = newnode;

                }
                else
                {
                    before.RightNode = newnode;
                }
            }
            return true;

        }
        public void TravarsePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.Data + "");
                TravarsePreorder(Parent.LeftNode);
                TravarsePreorder(Parent.RightNode);
            }
        }
    }
}
