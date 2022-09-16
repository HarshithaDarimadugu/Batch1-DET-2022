using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Batch1_DET__2022
{
    internal class LearningLINQ
    {
        public static void Main()
        {
            //SampleLinq();
            //Sample_OrderBy_Lambda_Numbers();

            //Sample_OrderByDescending_Lambda();
            //Sample_Reverse_Lambda();
            //Sample_ThenBy_Lambda();
            //Sample_ThenByDescending_Lambda();
            //Sample_Skip_Lambda();
            //Sample_SkipWhile_Lambda();
            //Sample_Take_Lambda();
            //Sample_TakeWhile_Lambda();
            //Sample_Aggregate_Lambda_Simple();
            //Sample_Average_Lambda();
            //Sample_Count_Lambda();
            //Sample_Max_Lambda();
            //Sample_Min_Lambda();
            //Sample_ElementAt_Lambda();
            //Sample_ElementAtOrDefault_Lambda();
            //Sample_First_Lambda_Simple();
            //Sample_First_Lambda_Conditional();
            //Sample_FirstOrDefault_Lambda();
            //Sample_Last_Lambda();
            //Sample_LastOrDefault_Simple();
            //Sample_LastOrDefault_Conditional();
            //Sample_Single_Lambda();
            //Sample_SingleOrDefault_Lambda();
            //Sample_All_Lambda();
            //Sample_Any_Lambda();
            //Sample_Contains_Lambda();
            //Sample_Distinct_Lambda();
            //Sample_Except_Lambda();
            //Sample_Intersect_Lambda();
            //Sample_Union_Lambda();
            string_Groupby();

        }
        //private static void SampleLinq()
        //{
        //    //Data source
        //    List<int> numbers = new List<int>();
        //    numbers.Add(101);
        //    numbers.Add(100);
        //    numbers.Add(121);
        //    numbers.Add(123);



        //    //query created
        //    //var numquery = from num in numbers
        //    //               where num > 102
        //    //               select num;

        //    //lambda expression
        //    var numquery = numbers.Where(x => x>102);

        //    //query execution
        //    foreach (int num in numquery)
        //    {
        //        Console.Write(" {0} ", num);
        //    }
        //    Console.ReadLine();
        //}
        //static void Sample_OrderBy_Lambda_Numbers()
        //{
        //    int[] numbers = { 7, 9, 5 };

        //    var result = numbers.OrderBy(n => n);

        //    Console.WriteLine("Ordered list of numbers:");

        //    foreach (int number in result)
        //    {
        //        Console.Write(numbers);
        //    }
        //    Console.ReadLine();
        //}

        //orderby simple -  numbers
        //static void Sample_OrderBy_Lambda_Numbers()
        //{
        //    int[] numbers = { 12, 45, 78 };

        //    var result = numbers.OrderBy(n => n);

        //   Console.WriteLine("Ordered list of numbers:");
        //    foreach (int number in result)
        //     Console.WriteLine(number);
        //}

        //orderby descending
        //static void Sample_OrderByDescending_Lambda()
        //{
        //    string[] names = {"Sri" ,"Harsh", "Vana", "lUCKY" };

        //    var result = names.OrderByDescending(n => n);

        //   Console.WriteLine("Descending ordered list of names:");
        //    foreach (string name in result)
        //       Console.WriteLine(name);
        //}

        //Reverse
        //static void Sample_Reverse_Lambda()
        //{
        //    char[] characters = { 'H', 'a', 'r', 's', 'h', 'i' };

        //    var result = characters.Reverse();

        //    Console.WriteLine("Characters in reverse order:");
        //    foreach (char character in result)
        //        Console.WriteLine(character);
        //}

        //Thenby
        //static void Sample_ThenBy_Lambda()
        //{
        //    string[] capitals = { "U.S.A", "Tokyo", "London" };

        //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console.WriteLine(capital);
        //}

        //static void Sample_ThenByDescending_Lambda()
        //{
        //    string[] capitals = { "U.S.A", "Tokyo", "London" };

        //    var result = capitals.OrderBy(c => c.Length).ThenByDescending(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console.WriteLine(capital);
        //}

        //PARTIONING
        //Skip
        //static void Sample_Skip_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.Skip(4);

        //    Console.WriteLine("Skips the first 4 words:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}

        //SkipWhile
        //static void Sample_SkipWhile_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.SkipWhile(w => w.Length == 3);

        //   Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}

        //Take
        //static void Sample_Take_Lambda()
        //{
        //    int[] numbers = { 10, 22, 35, 45, 50, 66, 7, 8, 98, 10 };

        //    var result = numbers.Take(7);

        //    Console.WriteLine("Takes the first 5 numbers only:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        //TakeWhile
        //static void Sample_TakeWhile_Lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.TakeWhile(n => n < 5);

        //    Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //    foreach (int number in result)
        //        Console.WriteLine(numbers);
        //}

        //Aggregate
        //simple
        //private static void Sample_Aggregate_Lambda_Simple()
        //{
        //    var numbers = new int[] { 6, 7, 8, 9, 1 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}

        //Average
        static void Sample_Average_Lambda()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }

        //Count
        static void Sample_Count_Lambda()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Alien", "Tim" };

            var result = names.Count();

           Console.WriteLine("Counting names gives:");
           Console.WriteLine(result);
        }

        //Max number
        static void Sample_Max_Lambda()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

        //min number
        static void Sample_Min_Lambda()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }

        //element
        //element at
        static void Sample_ElementAt_Lambda()
        {
            string[] words = { "One", "seven", "Three" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);
        }

        //elementat or default
        static void Sample_ElementAtOrDefault_Lambda()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex0 = colors.ElementAtOrDefault(0);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 0 in the array does not exist:");
            Console.WriteLine(resultIndex0 == null);
        }

        //FIRST
        static void Sample_First_Lambda_Simple()
        {
            string[] fruits = { "kiwi" ,"Banana", "Apple", "Orange" };

            var result = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }

        //First condition
        static void Sample_First_Lambda_Conditional()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };

            var result = countries.First(c => c.Length == 6);

            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);
        }

        //firstordefault
        static void Sample_FirstOrDefault_Lambda()
        {
            string[] countries = { "Denmark", "Sweden", "Norway", "Switzerland" };
            string[] empty = { };

            var result = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == "Switzerland");
        }

        //lAST
        static void Sample_Last_Lambda()
        {
            int[] numbers = { 7, 3, 5 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);
        }

        //lastordefaultsimple
        static void Sample_LastOrDefault_Simple()
        {
            string[] words = { "one", "two", "three" };
            string[] empty = { };

            var result = words.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }

        //lastordefault condition
        static void Sample_LastOrDefault_Conditional()
        {
            string[] words = { "one", "two", "three" };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }

        //single
        static void Sample_Single_Lambda()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.Single();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            try
            {
                // This will throw an exception because array contains no elements
                var resultEmpty = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //single or default
        static void Sample_SingleOrDefault_Lambda()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Quantifiers
        //all
        static void Sample_All_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("F"));

            Console.WriteLine("Does all of the names start with the letter 'F':");
            Console.WriteLine(result);
        }

        //ANY
        static void Sample_Any_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("O"));

            Console.WriteLine("Does any of the names start with the letter 'O':");
            Console.WriteLine(result);
        }

        //CONTAINS
        static void Sample_Contains_Lambda()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(15);

            Console.WriteLine("sequence contains the value 15:");
            Console.WriteLine(result);
        }

        //Distinct
        static void Sample_Distinct_Lambda()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        //Except
        static void Sample_Except_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        //Intersect
        static void Sample_Intersect_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        //Union
        static void Sample_Union_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }


        //Groupby

        private static void string_Groupby()
        {
            List<string> list = new List<string> { "basketball", "banana", "bhanu", "ghost", "gang", "Jeep" };

            //var result = from w in list
            //             group w by w[0] into g
            //             select new { firstletter = g.Key, list = g };

            var result = list.GroupBy(x => x[0]).Select(y => new { firstletter = y.Key, list = y });

            foreach (var item in result)
            {
                Console.WriteLine("words start with" + "letter '{0}': ", item.firstletter);

                foreach (var w in item.list)
                {
                    Console.WriteLine(w);
                }
            }
            Console.ReadLine();



           

        }
    }


}
