using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class strings
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("harshi"));
            Console.WriteLine(first_last("lucky"));
            Console.WriteLine(first_last("devi"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
    
