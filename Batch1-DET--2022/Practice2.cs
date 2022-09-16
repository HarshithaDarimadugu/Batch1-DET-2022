using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Myclass
{
        public static string Getsmall(int a, int b, out string res)
        {
        if (a > b)
            return res = "Smaller";
        else
            return res = "larger"; 
        }
        public static void Main()
        {
            int a, b;
            string res;

            Console.WriteLine("Enter the number a ?");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number b ?");
            b = Convert.ToInt32(Console.ReadLine());

            string result = Getsmall(a, b, out res);
            Console.WriteLine($" the output is (res)");

        }
 
}

        

