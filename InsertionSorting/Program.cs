using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var alg = new Sorting<int>();
            //List<int> coll = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                alg.Items.Add(rnd.Next(5, 100));
            }
            foreach (var item in alg.Items)
            {
                Console.Write(" " + item);
            }

            alg.Sort();

            Console.WriteLine();
            foreach (var item in alg.Items)
            {
                Console.Write(" +" + item);
            }
            Console.ReadLine();
        }
    }
}
