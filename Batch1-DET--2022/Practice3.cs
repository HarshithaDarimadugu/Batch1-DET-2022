using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Practice3
    {
        public static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' || ch == 'O' || ch == 'U');
        }
        public static int countVowels(string str)
        {
            int count = 0;
            for (int i =0; i < str.Length; i++)
            {
                if(isVowel(str[i]))
                {
                    count++;
                }

            }
            return count;
        }
        public static void mAIN(string[] args)
        {
            string str = "harshi";

            Console.WriteLine(countVowels(str));
        }
    }
}
