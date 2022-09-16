using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class operation
    {
        public static void Main()
        {
            string[] names = { "Vanu", "Lucky", "Harsh", "Bhan", "Babu", "Devi" };
            Console.WriteLine(names.Count());
            Console.WriteLine(names.Length);
            foreach (string name in names) 
            Console.WriteLine(name.ToUpper());
            foreach (string name in names)
                Console.WriteLine(name.ToLower());
            foreach (string name in names)
                Array.Reverse(names);
                Console.WriteLine(names);
        }
    }
}
