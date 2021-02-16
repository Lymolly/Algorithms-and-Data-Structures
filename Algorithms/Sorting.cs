using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Algorithms
{
    public class Sorting<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0; // Подсчет свапов
        
        public TimeSpan Sort(List<T> coll)
        {
            var timer = new Stopwatch();
            timer.Start();
            SwapCount = 0;
            MakeBubbleSorting(coll);
            timer.Stop();
            return timer.Elapsed;
        }
        protected List<T> MakeBubbleSorting(List<T> coll)
        {
            var count = coll.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    var a = coll[j];
                    var b = coll[j + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swap(coll, j, j + 1);
                    }
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
