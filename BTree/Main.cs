﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            Console.WriteLine("Ввод количества елементов");
            int n = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("Ввод елементов");
            for (int i=0; i<n; i++)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                tree.Add(val);
            }

            Console.WriteLine("Искомый елемент");
            int findable = Convert.ToInt32(Console.ReadLine());
            tree.FindElement(findable);
            tree.Output();
            
        }
    }
}
