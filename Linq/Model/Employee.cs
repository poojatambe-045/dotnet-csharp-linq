using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
    class Employee1
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public static List<Employee1> GetAllEmployees()
        {
            List<Employee1> employees = new List<Employee1>
            {
                new Employee1 { Name = "Alice", Department = "IT", Role = "Developer" },
                new Employee1 { Name = "Bob", Department = "IT", Role = "Tester" },
                new Employee1 { Name = "Charlie", Department = "HR", Role = "Recruiter" },
                new Employee1 { Name = "David", Department = "IT", Role = "Developer" },
                new Employee1 { Name = "Eve", Department = "HR", Role = "Manager" },
                new Employee1 { Name = "Frank", Department = "IT", Role = "Developer" }
            };
            return employees;
        }
    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
    public class Employee2
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
    public class EmployeePaging
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<EmployeePaging> GetAllEmployees()
        {
            return new List<EmployeePaging>()
            {
                new EmployeePaging() {ID = 1, Name = "Pranaya", Department = "IT" },
                new EmployeePaging() {ID = 2, Name = "Priyanka", Department = "IT" },
                new EmployeePaging() {ID = 3, Name = "Preety", Department = "IT" },
                new EmployeePaging() {ID = 4, Name = "Sambit", Department = "IT" },
                new EmployeePaging() {ID = 5, Name = "Sudhanshu", Department = "HR" },
                new EmployeePaging() {ID = 6, Name = "Santosh", Department = "HR" },
                new EmployeePaging() {ID = 7, Name = "Happy", Department = "HR" },
                new EmployeePaging() {ID = 8, Name = "Raja", Department = "IT" },
                new EmployeePaging() {ID = 9, Name = "Tarun", Department = "IT" },
                new EmployeePaging() {ID = 10, Name = "Bablu", Department = "IT" },
                new EmployeePaging() {ID = 11, Name = "Hina", Department = "HR" },
                new EmployeePaging() {ID = 12, Name = "Anurag", Department = "HR" },
                new EmployeePaging() {ID = 13, Name = "Dillip", Department = "HR" },
                new EmployeePaging() {ID = 14, Name = "Manoj", Department = "HR" },
                new EmployeePaging() {ID = 15, Name = "Lima", Department = "IT" },
                new EmployeePaging() {ID = 16, Name = "Sona", Department = "IT" },
            };
        }
    }
}
