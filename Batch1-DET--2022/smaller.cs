using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Myclass
{
    public static string Getsmall(int a, int b, out string small)
    {
        if (a > b)
            return small = " b";
        else
            return small = " a";
    }
    public static void Main()
    {
        int a, b;

        Console.WriteLine("Enter the number a ?");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number b ?");
        b = Convert.ToInt32(Console.ReadLine());

        string result = Getsmall(a, b, out result);
        Console.WriteLine($" the output of smaller number is {result}");


    }
}
