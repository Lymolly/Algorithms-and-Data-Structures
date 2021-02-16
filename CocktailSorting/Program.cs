using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            var cocktail = new Sorting<int>();
            
            List<int> coll = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                coll.Add(rnd.Next(2, 55));
            }
            foreach (var item in coll)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            cocktail.Sort(coll);
            Console.WriteLine("Swaps count: {0}",cocktail.SwapCount);
            Console.WriteLine();

            foreach (var item in coll)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadLine();
        }
    }
}
