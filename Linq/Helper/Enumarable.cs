using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Enumarable
    {
        public Enumarable() 
        {
            //---------------------------- Enumarable
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);
            List<int> e = intList.Where(x => x % 2 == 0).Select(x => x).ToList();
            int ints = Enumerable.Sum(intList);

        }

    }
}
