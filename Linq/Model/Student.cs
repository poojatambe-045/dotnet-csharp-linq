using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public static class ExtensionHelper
    {
        public static int GetWordCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Student1> GetStudents()
        {
            return new List<Student1>()
            {
                new Student1 { ID = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age = 20 },
                new Student1 { ID = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age = 21  },
                new Student1 { ID = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age = 21  },
                new Student1 { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
                new Student1 { ID = 1005, Name = "Hina", Gender = "Female", Branch = "ETC", Age = 20 },
                new Student1 { ID = 1006, Name = "Priyanka", Gender = "Female", Branch = "CSE", Age = 21 },
                new Student1 { ID = 1007, Name = "santosh", Gender = "Male", Branch = "CSE", Age = 22  },
                new Student1 { ID = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age = 20  },
                new Student1 { ID = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age = 22 },
                new Student1 { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 21 }
            };
        }
    }
    public class StudentGroup
    {
        public string Key { get; set; }
        public List<Student1> Students { get; set; }
    }
    public class StudentGroupByBranchGender
    {
        public string Branch { get; set; }
        public string Gender { get; set; }
        public List<Student1> Students { get; set; }
    }
}
