using System.Security.Cryptography.X509Certificates;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            tree.Add(22);
            tree.Add(40);
            tree.Add(11);
            tree.Add(3);
            tree.Add(16);
            tree.Add(60);
            tree.Add(95);
            tree.Add(65);
            tree.Add(63);
            tree.Add(67);

            Console.WriteLine("PREORDER");
            tree.TravarsePreorder(tree.Root);
            Console.WriteLine("\n");
            Console.WriteLine("POSTORDER");
            tree.Postorder(tree.Root);
            Console.WriteLine("\n"); 
            Console.WriteLine("INORDER");
            tree.Inorder(tree.Root);
           
        }
    }
}