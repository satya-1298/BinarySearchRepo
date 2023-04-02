using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node Root { get; set; }
        int lcount = 0;
        int rcount = 0;
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
                    lcount++;

                }
                else
                {
                    before.RightNode = newnode;
                    rcount++;
                }
            }
            return true;
        }


        public void TravarsePreorder(Node Parent)
        {

            if (Parent != null)
            {

                Console.Write(Parent.Data + " ");
                TravarsePreorder(Parent.LeftNode);
                TravarsePreorder(Parent.RightNode);
            }
        }
        public void Postorder(Node Parent)
        {

            if (Parent != null)
            {

                Postorder(Parent.LeftNode);
                Postorder(Parent.RightNode);
                Console.Write(Parent.Data + " ");
            }
        }
        public void Inorder(Node Parent)
        {

            if (Parent != null)
            {

                Postorder(Parent.LeftNode);
                Console.Write(Parent.Data + " ");
                Postorder(Parent.RightNode);

            }
        }
        public void size()
        {
           int s = lcount + rcount+1;
            Console.WriteLine(s);
        }
        public int value;
        
        bool result=false;
        public bool search( int value,Node Parent)
        {
            if (Parent == null)
            {
                Console.WriteLine("Node not found");
                return false;
            }
           else if (Parent.Data.Equals(value))
           {
                Console.WriteLine("Found the Element"+Parent.Data);
                return true;
                
           }
           else if(value.CompareTo(Parent.Data) < 0) 
            {
                search(value,Parent.LeftNode);
            }
           else if(value.CompareTo(Parent.Data)>0)
            {
                search(value,Parent.RightNode);
            }
            else
            {
                Console.WriteLine("Not Found node in BST");
            }
            return result;

        }

    }
}
