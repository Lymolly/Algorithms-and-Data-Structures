using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var bubble = new Sorting<int>();
            List<int> coll = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                coll.Add(rnd.Next(2,55));
            }
            foreach (var item in coll)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',20));
            bubble.Sort(coll);
            foreach (var item in coll)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadLine();
        }

        
    }
     
}
