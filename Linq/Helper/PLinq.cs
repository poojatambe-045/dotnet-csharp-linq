using Linq.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class PLinq
    {
        public PLinq() 
        {
            //---------------------------PLinq
            var numbers = Enumerable.Range(1, 20);
            var parallelQuery = numbers.AsParallel().Where(n => n % 2 == 0).ToList();

            // Creating an in-memory collection
            var nubers = Enumerable.Range(1, 10000000);
            // LINQ Query
            var stopwatch = Stopwatch.StartNew();
            var linqResults = nubers.Where(n => n % 2 != 0)
                                     .Select(n => n * n)
                                     .ToList();
            stopwatch.Stop();
            Console.WriteLine($"LINQ Query Time: {stopwatch.ElapsedMilliseconds} ms");
            // PLINQ Query
            stopwatch.Restart();
            var plinqResults = nubers.AsParallel()
                                      .Where(n => n % 2 != 0)
                                      .Select(n => n * n)
                                      .ToList();
            stopwatch.Stop();
            Console.WriteLine($"PLINQ Query Time: {stopwatch.ElapsedMilliseconds} ms");


        }

    }
}
