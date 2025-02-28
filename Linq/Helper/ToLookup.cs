using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class ToLookup
    {
        public ToLookup() 
        {
            //LINQ ToLookup Method
            var stds = Student1.GetStudents().ToLookup(x => x.Branch);
            var studs = Student1.GetStudents().ToLookup(x => x.Gender).OrderByDescending(y => y.Key).Select(stud => new { Gender = stud.Key, Students = stud.OrderBy(x => x.Name).ToList() });
            var stud1 = Student1.GetStudents().ToLookup(x => x.Gender).OrderByDescending(y => y.Key).Select(stud => new StudentGroup { Key = stud.Key, Students = stud.OrderBy(x => x.Name).ToList() });
            var gropstud = Student1.GetStudents().ToLookup(y => new { y.Branch, y.Gender }).Select(stud => new { Branch = stud.Key.Branch, Gender = stud.Key.Gender, Students = stud.OrderBy(x => x.Name) }).ToList();

            var lstt = Student1.GetStudents().ToLookup(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(y => y.Key.Gender).Select(Stud => new StudentGroupByBranchGender { Branch = Stud.Key.Branch, Gender = Stud.Key.Gender, Students = Stud.OrderBy(x => x.Name).ToList() }).ToList();


        }

    }
}
