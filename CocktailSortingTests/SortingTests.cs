using Microsoft.VisualStudio.TestTools.UnitTesting;
using CocktailSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSorting.Tests
{
    [TestClass()]
    public class SortingTests
    {
        [TestMethod()]
        public void CocktailSortingTest()
        {
            //arrange

            var cocktail = new Sorting<int>();
            var rnd = new Random();
            var coll = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                coll.Add(rnd.Next(1, 255));
            }
            coll.AddRange(coll);
            var sorted = coll.OrderBy(x => x).ToArray();

            //act
            coll.Sort();

            //assert
            for (int i = 0; i < coll.Count; i++)
            {
                Assert.AreEqual(sorted[i], coll[i]);
            }

        }
    }
}