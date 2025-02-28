using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Common
    {
        public Common() 
        {
            //------------------------------------sum of list value
            List<int> integerList = new List<int>()
            {
                1, 2
            };

            var lst = integerList.Where(x => x > 3).Select(x => x).ToList();
            var lst3 = integerList.Sum(x => x);

            //-------------------------------------Sum of Numbers
            var s = Convert.ToString(18).ToArray().Sum(c => int.Parse(c.ToString()));

            //-------------------------------------Novel counts
            string str = "Welcome";
            Dictionary<string, int> dict = str.Replace(" ", string.Empty).GroupBy(x => x).Where(x => x.Key.ToString() == "o" || x.Key.ToString() == "e").ToDictionary(x => x.Key.ToString(), x => x.Count());


        }

    }
}
