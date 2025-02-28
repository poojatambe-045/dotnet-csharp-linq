using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class QuantifiersOperators
    {
        public QuantifiersOperators() 
        {
            //----------------------Quantifiers Operators
            int[] ints6 = { 1, 2, 3, 4, 9, 6, 7, 8, 10, 11 };
            bool any = ints6.Any(x => x > 40);
            bool any1 = ints6.Any(x => x < 40);
            bool all = ints6.All(x => x > 40);
            bool all1 = ints6.All(x => x < 40);
            bool contains = ints6.Contains(4);
            bool contains1 = ints6.Contains(40);
        }

    }
}
