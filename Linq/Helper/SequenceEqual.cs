using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class SequenceEqual
    {
        public SequenceEqual() 
        {

            //-------------------------SequenceEqual
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };

            List<string> cityList2 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Checking if both Sequences are Equal or not
            bool IsEqualMS = cityList1.SequenceEqual(cityList2);

            bool IsEqualMS2 = cityList1.OrderBy(city => city).SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);


        }

    }
}
