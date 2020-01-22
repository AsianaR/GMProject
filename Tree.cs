using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {
        }
        public Node(int data)
        {
            this.value = value;
        }
    }
    public class BinaryTree
    {
        private Node xroot;
        public BinaryTree()
        {
            xroot = null;
        }
        public void Insert(int value)
        {
            
            if (xroot == null)
            {
                xroot = new Node(value);
                return;
            }
            
            InsertRec(xroot, new Node(value));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.value < root.value)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.value + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(xroot);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                tree.Insert(val);
            }
            tree.DisplayTree();
        }
    }
}
