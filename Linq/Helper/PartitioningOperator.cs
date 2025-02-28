using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class PartitioningOperator
    {
        public PartitioningOperator() 
        {
            //---------------------------Partitioning Operators
            List<int> ints7 = [2, 6, 78, 8, 9, 8, 4, 65, 778, 2, 7];

            // Take the first 5 numbers
            IEnumerable<int> firstFive = ints7.Take(5);
            // Take numbers while they are less than 6
            IEnumerable<int> lessThanSix = ints7.TakeWhile(n => n < 6);
            // Skip the first 5 numbers
            IEnumerable<int> skipFirstFive = ints7.Skip(5);
            // Skip numbers while they are less than 6
            IEnumerable<int> skipLessThanSix = ints7.SkipWhile(n => n < 6);

        }

    }
}
