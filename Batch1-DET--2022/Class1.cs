using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {

        public static int Getmultiply(int a, int b, int c)
        {
            return a * b * c;
        }
            public static void Main()
            {
                int a, b, c;

                Console.WriteLine("Enter the number a?");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number b?");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number c?");
                c = Convert.ToInt32(Console.ReadLine());

                int result = Getmultiply(a, b, c);
                Console.WriteLine($" The result of multiply is {result}");
            }



       
    }
}
