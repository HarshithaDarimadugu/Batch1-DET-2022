using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Exercise1
    {
        public static void Main()
        {
            int a, b, c;
            int result;
            Console.WriteLine("Enter the number a?");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number b?");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number c?");
            c = Convert.ToInt32(Console.ReadLine());

            result = a * b * c;
            result = int.Parse(Console.ReadLine());
            Console.WriteLine($" The result is {result}");
        }
    }
}

  

