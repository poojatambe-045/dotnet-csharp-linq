using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class ToArrayToListToDictionary
    {
        public ToArrayToListToDictionary() 
        {
            //--------------ToList() ToArray() ToDictionary()
            //--------------------ToList()
            //Creating Integer Array
            int[] numbersArray = { 10, 22, 30, 40, 50, 60 };
            //Converting Integer Array to List using ToList method
            List<int> numbersList = numbersArray.ToList();
            //Create an Array of Employees
            EmployeePaging[] EmployeesArray = new EmployeePaging[]
            {
                new EmployeePaging() {ID = 1, Name = "Pranaya", Department = "IT" },
                new EmployeePaging() {ID = 2, Name = "Priyanka", Department = "HR" },
                new EmployeePaging() {ID = 3, Name = "Preety", Department = "HR" },
                new EmployeePaging() {ID = 4, Name = "Sambit", Department = "IT" },
                new EmployeePaging() {ID = 5, Name = "Sudhanshu", Department = "IT"}
            };
            //Converting Array to List
            List<EmployeePaging> EmployeesList = EmployeesArray.ToList();
            //----------------ToArray()
            //Create a List
            List<int> numbersLis = new List<int>()
            {
                10, 22, 30, 40, 50, 60
            };
            //Converting List to Array
            int[] numbersArra = numbersLis.ToArray();
            List<EmployeePaging> EmployeesLi = new List<EmployeePaging>()
            {
                new EmployeePaging() {ID = 1, Name = "Pranaya", Department = "IT" },
                new EmployeePaging() {ID = 2, Name = "Priyanka", Department = "HR" },
                new EmployeePaging() {ID = 3, Name = "Preety", Department = "HR" },
                new EmployeePaging() {ID = 4, Name = "Sambit", Department = "IT" },
                new EmployeePaging() {ID = 5, Name = "Sudhanshu", Department = "IT"}
            };
            //Converting List to Array
            EmployeePaging[] EmployeesAr = EmployeesLi.ToArray();

            //----------------ToDictionary()
            List<Product> listProducts = Product.GetAllProducts();
            Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.Id);
            Dictionary<int, string> productsDictionar = listProducts.ToDictionary(x => x.Id, x => x.Name);
            Dictionary<int, string> productsDiction = listProducts.GroupBy(x => new { x.Id, x.Name }).ToDictionary(x => x.Key.Id, x => x.Key.Name);

        }

    }
}
