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
            tree.TravarsePreorder(tree.Root);

        }
    }
}