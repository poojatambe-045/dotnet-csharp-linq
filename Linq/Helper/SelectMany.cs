using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class SelectMany
    {
        public SelectMany() 
        {
            //------------------SelectMany
            List<string> strings1 = new List<string> { "pooja", "priya", "Pooja" };
            IEnumerable<char> chars = strings1.SelectMany(s => s);
            IEnumerable<char> chars1 = from stri in strings1
                                       from ch in stri
                                       select ch;
            //IEnumerable<char> chars2 = strings1.SelectMany(x => x.Select(y => y)).ToList();
            IEnumerable<string> chars2 = strings1.Select(x => x).ToList();
            IEnumerable<char> chars3 = strings1.SelectMany(x => x.ToLower()).Distinct().OrderBy(x => x).ToList();
            IEnumerable<char> chars4 = strings1.SelectMany(x => x).Distinct().OrderBy(x => x).ToList();

        }

    }
}
