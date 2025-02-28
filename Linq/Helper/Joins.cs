using Linq.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class Joins
    {
        public Joins() 
        {
            //Cross Join
            //Cross Join using SelectMany Method
            var CrossJoinResult = Student.GetAllStudents()
                        .SelectMany(sub => Subject.GetAllSubjects(),
                         (std, sub) => new
                         {
                             StudentName = std.Name,
                             SubjectName = sub.SubjectName
                         });
            //Cross Join using Join Method
            var CrossJoinResult2 = Student.GetAllStudents()
                        .Join(Subject.GetAllSubjects(),
                            std => true,
                            sub => true,
                            (std, sub) => new
                            {
                                StudentName = std.Name,
                                SubjectName = sub.SubjectName
                            }
                         );


            //Left Outer Join
            var MSOuterJOIN = Employee.GetAllEmployees() //Left Data Source
                                                         //Performing Group join with Right Data Source
                            .GroupJoin(
                                  Address.GetAllAddresses(), //Right Data Source
                                  employee => employee.AddressId, //Outer Key Selector, i.e. Left Data Source Common Property
                                  address => address.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                  (employee, address) => new { employee, address } //Projecting the Result
                            )
                            .SelectMany(
                                  x => x.address.DefaultIfEmpty(), //Performing Left Outer Join 
                                  (employee, address) => new { employee, address } //Final Result Set
                             );


            //Performing Left Outer Join using LINQ using Method Syntax
            var MSLeftOuterJOIN = Employee2.GetAllEmployees() //Left Data Source
                                                             //Performing Group join with Right Data Source
                              .GroupJoin(
                                    Department.GetAllDepartments(), //Right Data Source
                                    employee => employee.DepartmentId, //Outer Key Selector, i.e. Left Data Source Common Property
                                    department => department.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (employee, department) => new { employee, department } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.department.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                        //Final Result Set
                                    (employee, department) => new
                                    {
                                        EmployeeId = employee?.employee?.ID,
                                        EmployeeName = employee?.employee?.Name,
                                        DepartmentName = department?.Name
                                    }
                               );
            //Performing Right Outer Join using LINQ using Method Syntax
            var MSRightOuterJOIN = Department.GetAllDepartments() //Left Data Source
                                                                  //Performing Group join with Right Data Source
                              .GroupJoin(
                                    Employee2.GetAllEmployees(), //Right Data Source
                                    department => department.ID, //Outer Key Selector, i.e. Left Data Source Common Property
                                    employee => employee.DepartmentId, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (department, employee) => new { department, employee } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.employee.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                      //Final Result Set
                                    (department, employee) => new
                                    {
                                        EmployeeId = employee?.ID,
                                        EmployeeName = employee?.Name,
                                        DepartmentName = department?.department?.Name
                                    }
                               );
            var FullOuterJoin = MSLeftOuterJOIN.Union(MSRightOuterJOIN);


            //Group Join
            var GroupJoinMS = Department.GetAllDepartments(). //Outer Data Source i.e. Departments
                GroupJoin( //Performing Group Join with Inner Data Source
                    Employee2.GetAllEmployees(), //Inner Data Source
                    dept => dept.ID, //Outer Key Selector  i.e. the Common Property
                    emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
                    (dept, emp) => new { dept, emp } //Projecting the Result to an Anonymous Type
                );


            //Join with Multiple Data Sources
            var data = Employee2.GetAllEmployees().Join(Address.GetAllAddresses(), employee1 => employee1.AddressId, address1 => address1.ID, (employee1, address1) => new { employee1, address1 }).Join(Department.GetAllDepartments(), employee2 => employee2.employee1.DepartmentId, department1 => department1.ID, (employee2, department1) => new { employee2, department1 }).Select(x => new { EmployeeName = x.employee2.employee1.Name, Address = x.employee2.address1.AddressLine, DepartMent = x.department1.Name }).ToList();

            //Inner Join
            var result = Employee.GetAllEmployees().Join(Address.GetAllAddresses(), employee => employee.AddressId, address => address.ID, (employee, address) => new { Name = employee.Name, Address = address.AddressLine }).ToList();

            var result2=Employee.GetAllEmployees().Join(Address.GetAllAddresses(),employee=>employee.AddressId,address=>address.ID,(employee,address)=>new EmployeeAddress { EmployeeName=employee.Name,AddressLine=address.AddressLine}).ToList();

            var resultparallel = Employee.GetAllEmployees().AsParallel().Join(Address.GetAllAddresses().AsParallel(), employee => employee.AddressId, address => address.ID, (employee, address) => new EmployeeAddress { EmployeeName = employee.Name, AddressLine = address.AddressLine }).ToList();

            //Joins
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Alice" },
                new Customer { Id = 2, Name = "Bob" },
                new Customer { Id = 3, Name = "John" }
            };
            var orders = new List<Order2>
            {
                new Order2 { OrderId = 101, CustomerId = 1 },
                new Order2 { OrderId = 102, CustomerId = 2 },
                new Order2 { OrderId = 103, CustomerId = 1 },
                new Order2 { OrderId = 104, CustomerId = 3 }
            };
            //var result2 = from customer in customers
            //              join order in orders on customer.Id equals order.CustomerId
            //              select new { CustomerName = customer.Name, OrderId = order.OrderId };

            //var departments = new List<Department>
            //{
            //    new Department { DepartmentId = 1, Name = "HR" },
            //    new Department { DepartmentId = 2, Name = "IT" }
            //};
            //var employees = new List<Employee2>
            //{
            //    new Employee2 { EmployeeId = 101, DepartmentId = 1, Name = "Alice" },
            //    new Employee2 { EmployeeId = 102, DepartmentId = 2, Name = "Bob" },
            //    new Employee2 { EmployeeId = 103, DepartmentId = 1, Name = "Charlie" },
            //    new Employee2 { EmployeeId = 104, DepartmentId = 2, Name = "John" },
            //    new Employee2 { EmployeeId = 105, DepartmentId = 1, Name = "Smith" }
            //};

            ////Performing Group Join
            //var reslt = from department in departments
            //            join employee in employees on department.DepartmentId equals employee.DepartmentId into grouped
            //            select new { DepartmentName = department.Name, Employees = grouped };


        }

    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1 },
                new Employee { ID = 2, Name = "Priyanka", AddressId = 2 },
                new Employee { ID = 3, Name = "Anurag", AddressId = 3 },
                new Employee { ID = 4, Name = "Pranaya", AddressId = 4 },
                new Employee { ID = 5, Name = "Hina", AddressId = 5 },
                new Employee { ID = 6, Name = "Sambit", AddressId = 6 },
                new Employee { ID = 7, Name = "Happy", AddressId = 7},
                new Employee { ID = 8, Name = "Tarun", AddressId = 8 },
                new Employee { ID = 9, Name = "Santosh", AddressId = 9 },
                new Employee { ID = 10, Name = "Raja", AddressId = 10},
                new Employee { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
        }
    }
    public class Employee2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee2> GetAllEmployees()
        {
            return new List<Employee2>()
            {
                new Employee2 { ID = 1, Name = "Preety", AddressId = 1, DepartmentId = 10    },
                new Employee2 { ID = 2, Name = "Priyanka", AddressId = 2, DepartmentId =20   },
                new Employee2 { ID = 3, Name = "Anurag", AddressId = 3, DepartmentId = 30    },
                new Employee2 { ID = 4, Name = "Pranaya", AddressId = 4, DepartmentId = 0    },
                new Employee2 { ID = 5, Name = "Hina", AddressId = 5, DepartmentId = 0       },
                new Employee2 { ID = 6, Name = "Sambit", AddressId = 6, DepartmentId = 0     },
                new Employee2 { ID = 7, Name = "Happy", AddressId = 7, DepartmentId = 0      },
                new Employee2 { ID = 8, Name = "Tarun", AddressId = 8, DepartmentId = 0      },
                new Employee2 { ID = 9, Name = "Santosh", AddressId = 9, DepartmentId = 10   },
                new Employee2 { ID = 10, Name = "Raja", AddressId = 10, DepartmentId = 20    },
                new Employee2 { ID = 11, Name = "Ramesh", AddressId = 11, DepartmentId = 30  }
            };
        }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 3, AddressLine = "AddressLine3"},
                new Address { ID = 4, AddressLine = "AddressLine4"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 9, AddressLine = "AddressLine9"},
                new Address { ID = 10, AddressLine = "AddressLine10"},
                new Address { ID = 11, AddressLine = "AddressLine11"},
            };
        }
    }
    class EmployeeAddress
    {
        public string EmployeeName { get; set; }
        public string AddressLine { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"       },
                new Department { ID = 20, Name = "HR"       },
                new Department { ID = 30, Name = "Payroll"  },
            };
        }
    }
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety"},
                new Student { ID = 2, Name = "Priyanka"},
                new Student { ID = 3, Name = "Anurag"},
                new Student { ID = 4, Name = "Pranaya"},
                new Student { ID = 5, Name = "Hina"}
            };
        }
    }
}
