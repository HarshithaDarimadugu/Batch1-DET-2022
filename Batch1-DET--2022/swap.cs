using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        class Newclass
        {
            public static void swap(ref int a, ref int b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            public static void Main()
            {
                int a, b;

                Console.WriteLine("Enter the number a ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number b ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"before swapping a={a},b= {b}");

                swap(ref a, ref b);
                Console.WriteLine($"after swapping a={a}, b={b}");

            }
        }
    

