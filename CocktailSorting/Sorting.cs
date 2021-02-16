using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSorting
{
    public class Sorting<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0; //подсчет свапов чисел
        public TimeSpan Sort(List<T> coll)
        {
            var timer = new Stopwatch();
            timer.Start();
            SwapCount = 0;
            MakeCocktailSorting(coll);
            timer.Stop();
            return timer.Elapsed;
        }
        public List<T> MakeCocktailSorting(List<T> coll)
        {
            SwapCount = 0;
            int left = coll.Count - coll.Count; //или просто 0
            int right = coll.Count - 1;

            while (left < right)
            {
                var sc = SwapCount;
                for (int i = right; i > left; i--)
                {
                    if (coll[i].CompareTo(coll[i - 1]) == -1)
                    {
                        Swap(coll, i - 1, i);
                    }
                }
                left++;
                if (sc == SwapCount)
                {
                    break;
                }

                for (int i = 0; i < right; i++)
                {
                    if (coll[i].CompareTo(coll[i + 1]) == 1)
                    {
                        Swap(coll, i, i + 1);
                    }
                }
                right--;
                if (sc == SwapCount)
                {
                    break;
                }
            }
            return coll;
        }

        private List<T> Swap(List<T> coll, int a, int b)
        {
            if (a < coll.Count && b < coll.Count)
            {
                var temp = coll[a];
                coll[a] = coll[b];
                coll[b] = temp;
                SwapCount++;
            }
            return coll;
        }
    }
}
