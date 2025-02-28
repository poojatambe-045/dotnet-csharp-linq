using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class OfType
    {
        public OfType() 
        {
            //-------------------OfType
            ArrayList listoftype = new ArrayList
            {
                10,
                20,
                30,
                "50"
            };

            IEnumerable<int> resultoftype = listoftype.OfType<int>();


            //------------------------------OfType
            List<object> list6 = new List<object> { "ab", 8, 'b', 0, false, "ynk", 7, 3, 6, "y", true };
            List<int> ints3 = list6.OfType<int>().ToList();
            List<string> strings2 = list6.OfType<string>().ToList();
            List<char> chh = list6.OfType<char>().ToList();
            List<bool> bools = list6.OfType<bool>().ToList();
        }

    }
}
