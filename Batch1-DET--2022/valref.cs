using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class valref
    {
        public static void Main()
        {
            int i = 100;
            int j;
            j = i;
            Console.WriteLine(j);
            i++;
            Console.WriteLine(j);

            int[] arr1 = { 1, 2, 3 };
            int[] arr2;
            arr2 = arr1;

            arr1[0]++;

            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr1[0]);
        
        }

    }
}
