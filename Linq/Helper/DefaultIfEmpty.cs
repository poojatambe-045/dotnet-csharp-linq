using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class DefaultIfEmpty
    {
        public DefaultIfEmpty()
        {
            //-----------------------DefaultIfEmpty
            List<int> numbers2 = new List<int>();
            IEnumerable<int> resultMS = numbers2.DefaultIfEmpty();//returns 0
            IEnumerable<int> resultMS2 = numbers2.DefaultIfEmpty(5);//returns 5
        }

        }
    }
