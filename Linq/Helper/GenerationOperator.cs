using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class GenerationOperator
    {
        public GenerationOperator() 
        {
            //--------------------------Generation Operator
            //Zip
            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);

            var keys = new List<string> { "ID", "Name", "Email", "Mobile" };
            var values = new List<string> { "1", "Pranaya", "Pranaya@example.com", "1234567890" };
            var dictionary = keys.Zip(values, (k, v) => new { k, v })
                                 .ToDictionary(x => x.k, x => x.v);
            // Now dictionary contains { { "ID", "1" }, { "Name", "Pranaya" }, { "Email", "Pranaya@example.com" }, { "Mobile", "1234567890" } }

            //Prepend
            // Creating a list of numbers
            List<int> numberSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to prepend 50
            numberSequence.Prepend(50);
            // It will not work because the original sequence has not been changed
            Console.WriteLine(string.Join(", ", numberSequence));
            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numberSequence.Prepend(50)));
            // If you prefer, you can create a new list explicitly
            List<int> newnumberSequence = numberSequence.Prepend(50).ToList();
            // And then write to the console output
            Console.WriteLine(string.Join(", ", newnumberSequence));


            //Append
            // Creating a list of integer
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);
            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));
            // Creating a new sequence explicitly
            List<int> newintSequence = intSequence.Append(5).ToList();
            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));
            var numbe = new[] { 1, 2, 3 };
            var result8 = numbe
                .Where(x => x % 2 == 1) // Take odd numbers
                .Select(x => x * 10)    // Multiply them by 10
                .Append(100);           // Append the number 100 to the end
                                        // result now contains 10, 30, 100


            //Empty
            IEnumerable<string> emptyCollection1 = Enumerable.Empty<string>();
            //Creating Empty Collection of Student
            IEnumerable<Student> emptyCollection2 = Enumerable.Empty<Student>();

            //Repeate
            IEnumerable<string> strings3 = Enumerable.Repeat("Hi", 2);
            var key = Enumerable.Range(1, 10);
            var valus = Enumerable.Repeat("Default", 10);
            var joinedData = keys.Zip(values, (k, v) => new { Key = k, Value = v });
            var data = new List<int> { 1, 2, 3 };
            data.AddRange(Enumerable.Repeat(0, 5 - data.Count));
            var data2 = new List<int> { 1, 2, 3 };
            var sum = data2.Concat(Enumerable.Repeat(0, 5 - data.Count)).Sum();

            //Range
            //Generating Intger Numbers from 1 to 10
            IEnumerable<int> ints8 = Enumerable.Range(1, 10);
            IEnumerable<int> ints9 = Enumerable.Range(10, 50).Where(x => x % 2 == 0);
            IEnumerable<int> ints10 = Enumerable.Range(1, 10).Select(x => x * 2);
            IEnumerable<string> ints11 = Enumerable.Range(1, 10).Select(x => (x * 2) + " Num").ToArray();
            DateTime startDate = new DateTime(2021, 1, 1);
            int daysToGenerate = 10;
            var dateSequence = Enumerable.Range(0, daysToGenerate)
                                         .Select(offset => startDate.AddDays(offset));


        }

    }
}
