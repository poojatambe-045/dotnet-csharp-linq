using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Helper
{
    internal class ExtentionMethod
    {
        public ExtentionMethod() 
        {
            //-------------------------------------------------- Extension method
            string sentence = "Welcome to Dotnet Tutorials 888";
            int wordCount = sentence.GetWordCount();
            Console.WriteLine($"Count : {wordCount}");
        }
        
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
}
