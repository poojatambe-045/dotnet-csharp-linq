using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class ImmediateExecutionDeferredExecution
    {
        public ImmediateExecutionDeferredExecution() 
        {
            //----------------------ImmediateExecutionDeferredExecution
            //Methods that trigger immediate execution include ToList(), ToArray(), ToDictionary(), Count(), First(), Single(),
            //and others that force the query to be executed right away
            List<Linq.Model.Employee> listEmployees = new List<Linq.Model.Employee>
            {
                new Linq.Model.Employee { ID= 1001, FirstName = "Priyanka", Salary = 80000 },
                new Linq.Model.Employee { ID= 1002, FirstName = "Anurag", Salary = 90000 },
                new Linq.Model.Employee { ID= 1003, FirstName = "Preety", Salary = 80000 }
            };
            var lste = listEmployees.Where(x => x.Salary == 8000);   //Deferred Execution
            var lst4 = listEmployees.Where(x => x.Salary == 80000).ToList();  //Immediate Execution

            listEmployees.Add(new Linq.Model.Employee { ID = 1004, FirstName = "Santosh", Salary = 80000 });

        }

    }
}
