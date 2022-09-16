using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class COUNTWORDS
    {
    
            public static void Main()
            {
                int a = 0, w = 1;
                string str = "Hi welcome to the world!";
                while (a <= str.Length - 1)
                {
                    if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                    {
                        w++;
                    }
                    a++;
                }
                Console.Write("Number of words in the string = {0}\n", w);
            }
        }
    }