using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Model;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(5);
            list.Add(7);
            list.Add(1);
            list.Add(6);
            list.Add(2);
            list.Insert(5, 9);
            list.Append(22);
            list.Add(18);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-',10));

            list.Remove(18);
            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Clear();
            Console.ReadLine();
        }
    }
}
