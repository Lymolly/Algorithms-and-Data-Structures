using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorting
{
    class Sorting<T> where T : IComparable
    {
        public List<int> Items = new List<int>();
        public void MakeInsertionSort()//List<T> coll)
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;
                while(j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                }
                Items[j] = temp;
            }
            //return coll;
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            timer.Start();
            MakeInsertionSort();
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
