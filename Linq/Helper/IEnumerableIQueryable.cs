using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class IEnumerableIQueryable
    {
        public IEnumerableIQueryable() 
        {
            //--------------------------Linq Query to Fetch all students with Gender Male  IEnumerableIQueryable
            List<Linq.Model.Student> studentList = new List<Linq.Model.Student>()
            {
                new Linq.Model.Student(){ID = 1, Name = "James", Gender = "Male"},
                new Linq.Model.Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Linq.Model.Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Linq.Model.Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            IEnumerable<Linq.Model.Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;

            IEnumerable<Linq.Model.Student> QuerySyntax1 = studentList.Where(std => std.Gender == "Male").Select(std => std);

            IQueryable<Linq.Model.Student> MethodSyntax = studentList.AsQueryable()
                                            .Where(std => std.Gender == "Male");

            IEnumerable<Linq.Model.Student> MethodSyntax2 = studentList.AsEnumerable()
                                            .Where(std => std.Gender == "Male");

        }

    }
}
