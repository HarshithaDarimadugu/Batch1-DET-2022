using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET__2022
{
    internal class linqassignment
    {
        public static void Main()
        {
            Findingelement();
            //Findinglength();
            //Sample_Reverse_Lambda();


        }
        static void  Findingelement()
        {
            string[] names = { "John", "Peter", "Jacob",  "Harry", "Jackson" };

            var result = names.Where(word => word.Contains("o"));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        static void Findinglength()
        {
            string[] capitals = { "Peter", "john",  "Jackson", "Jacob", "Harry" };

            var result = capitals.OrderBy(c => c.Length).ThenByDescending(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }

        static void Sample_Reverse_Lambda()
        {
            string[] words = { "blueberry", "blackberry", "abacus" };

            var result = words.Reverse();

            Console.WriteLine("string in reverse order:");

            foreach (var characters in result)
            {
                Console.WriteLine(characters);

            }
              
        }
    }
}
