using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class GroupBy
    {
        public GroupBy() 
        {
            //------------------------------Group by
            //Using Method Syntax
            IEnumerable<IGrouping<string, Student1>> GroupByMS = Student1.GetStudents().GroupBy(s => s.Branch);
            var values0 = Student1.GetStudents().GroupBy(s => s.Branch);

            //Using Query Syntax
            IEnumerable<IGrouping<string, Student1>> GroupByQS = (from std in Student1.GetStudents()
                                                                  group std by std.Branch);

            var studentgr = Student1.GetStudents().GroupBy(x => x.Branch).Select(std => new { Key = std.Key, students = std.OrderBy(o => o.Name) });
            var studentgr1 = Student1.GetStudents().GroupBy(x => x.Branch).OrderBy(c => c.Key).Select(std => new { Key = std.Key, students = std.OrderBy(o => o.Name) });

            var lstgroup = Student1.GetStudents().GroupBy(x => x.Branch).Select(std => new StudentGroup { Key = std.Key, Students = std.OrderBy(o => o.Name).ToList() });

            var totalorder = Order.GetAllOrders().GroupBy(x => x.CustomerId).Select(order => new { key = order.Key, total = order.Sum(x => x.Amount) });

            //Hierarchical Data
            var emplist = Employee1.GetAllEmployees().GroupBy(x => x.Department).Select(y => new { department = y.Key, role = y.GroupBy(x => x.Role).Select(z => new { role = z.Key, employee = z.ToList() }).ToList() }).ToList();

            //Removing Duplicates
            var products = Product.GetAllProducts().GroupBy(x => x.Name).Select(y => y.First()).ToList();
            //Data Analysis 
            var saleData = Sale.GetAllSales().GroupBy(x => new { x.ProductId, Month = x.SaleDate.Month }).Select(y => new { y.Key.ProductId, y.Key.Month, TotalQuantity = y.Sum(y => y.Quantity) }).OrderBy(result => result.ProductId).ThenBy(result => result.Month).ToList();


        }

    }
}
