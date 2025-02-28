using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Where
    {
        public Where() 
        {
            //----------------------Where
            List<int> ints1 = new List<int> { 1, 4, 5, 7, 22, 12 };
            List<int> ints2 = ints1.Where(x => x.ToString().Contains("2")).Select(x => x).ToList();

        }

    }
}
