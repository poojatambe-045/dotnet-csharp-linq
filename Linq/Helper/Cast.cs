using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Cast
    {
        public Cast() 
        {

            //----------------------Cast
            ArrayList list = new ArrayList
            {
                10,
                20,
                30
            };
            IEnumerable<int> result = list.Cast<int>();
        }
        
    }
}
