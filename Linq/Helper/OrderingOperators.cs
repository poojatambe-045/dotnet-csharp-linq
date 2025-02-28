using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class OrderingOperators
    {
        public OrderingOperators()
        {

            //-------------Ordering Operators
            var personlst = new List<Person>()
{
    new Person{FirstName="Pooja",LastName="Tambe",Age=80},
    new Person{FirstName="Aayansh",LastName="Tambe",Age=67},
    new Person { FirstName = "John", LastName = "Doe", Age = 30 },
    new Person { FirstName = "Jane", LastName = "Doe", Age = 25 },
    new Person { FirstName = "Joe", LastName = "Bloggs", Age = 30 },
};
            var Newlst = personlst.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenByDescending(x => x.Age).ToList();

        }

    }
}
