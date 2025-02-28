using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class AggregateOperators
    {
        public AggregateOperators() 
        {
            //------------------Aggregate Operators
            var lstt9 = new List<int> { 4, 6, 77, 8, 9 };
            var lstt10 = new List<double> { 4, 6, 77, 8, 9 };
            int sum4 = lstt9.Sum(x => x);
            int count = lstt9.Count();
            int max = lstt9.Max(x => x);
            int min = lstt9.Min(x => x);
            double average = lstt10.Average(x => x);
            int aggregatesum = lstt9.Aggregate((accumulator, number) => accumulator + number);
            int aggregatestar = lstt9.Aggregate((accumulator, number) => accumulator * number);
        }

    }
}
