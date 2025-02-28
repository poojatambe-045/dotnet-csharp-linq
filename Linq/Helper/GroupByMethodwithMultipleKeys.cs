using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class GroupByMethodwithMultipleKeys
    {
        public GroupByMethodwithMultipleKeys() 
        {
            //LINQ GroupBy Method with Multiple Keys
            var listt = Student1.GetStudents().GroupBy(x => new { x.Branch, x.Gender }).Select(y => new { Branch = y.Key.Branch, Gender = y.Key.Gender, Students = y.OrderBy(x => x.Name) }).ToList();
            var listt4 = Student1.GetStudents().GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(t => t.Key.Gender).Select(student => new { Branch = student.Key.Branch, Gender = student.Key.Gender, students = student.OrderBy(x => x.Name) }).ToList();

            var lstt2 = Student1.GetStudents().GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(y => y.Key.Gender).Select(Stud => new StudentGroupByBranchGender { Branch = Stud.Key.Branch, Gender = Stud.Key.Gender, Students = Stud.OrderBy(x => x.Name).ToList() }).ToList();

            var orders8 = Order1.GetAllOrders().GroupBy(x => new { x.CustomerId, OrderYear = x.OrderDate.Year }).Select(y => new { CustomerId = y.Key.CustomerId, OrderYear = y.Key.OrderYear, TotalOrders = y.Count(), TotalAmount = y.Sum(x => x.Total) }).ToList();

            var Salerecord = SaleRecord.GetAllSales().GroupBy(x => new { x.Country, x.Year }).Select(rec => new { Country = rec.Key.Country, Year = rec.Key.Year, TotalAmount = rec.Sum(y => y.Amount), SaleCount = rec.Count() }).ToList();

            var lstem = Employee1.GetAllEmployees().GroupBy(x => new { x.Department, x.Role }).Select(emp => new { Department = emp.Key.Department, Role = emp.Key.Role, Employees = emp.ToList() }).ToList();

        }

    }
}
