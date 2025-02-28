using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Reverse
    {
        public Reverse() 
        {
            //---------------Reverse
            int[] ints4 = new int[] { 2, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            int[] ints5 = ints4.Reverse().ToArray();
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };
            stringList.Reverse();
        }

    }
}
