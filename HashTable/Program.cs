using System;
using System.Collections.Generic;
using BinaryTree;

namespace BinaryTree
{
    class Program
    {
        //public delegate List<int> Order();
        static void Main(string[] args)
        {

            Tree<int> tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            //Order order;
            //var key = Console.ReadKey();
            //if (key.Key == ConsoleKey.Q)
            //{
            //    order = tree.PreOrder;
            //}
            //else if (key.Key == ConsoleKey.W)
            //{
            //    order = tree.PostOrder;
            //}
            foreach (var item in tree.InfixOrder())
            {
                Console.Write(item +" ");
            }
            Console.ReadLine();
        }
    }
}
