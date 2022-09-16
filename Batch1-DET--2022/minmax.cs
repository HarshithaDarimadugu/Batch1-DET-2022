using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class minmax
    {
        public static void Main()
        {
            int[] array;
            array = new int[5];
            array[0] = 1;
            array[1] = 2;   
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine($"the maximum element in array {array.Max()}");
            Console.WriteLine($"the minimum element in array {array.Min()}");
            
        }

    } 
}

