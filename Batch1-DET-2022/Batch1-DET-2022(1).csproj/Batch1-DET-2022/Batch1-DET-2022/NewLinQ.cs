using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class NewLinQ
    {
        public static void Main()
        {
            // All();
            //Any();
            //Contains();
            // Distinct();
            //Except();
            // Intersect();
            //  Union();
            // Containing();
            // Maxlngth();
            string_groupby();

        }
        static void All()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        static void Any()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        static void Contains()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }
        static void Distinct()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Except()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Intersect()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Union()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Containing()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            var result = names.Where(word => word.Contains("o"));
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            // Console.WriteLine("sequence contains the value o:");
            //Console.WriteLine(result);
        }
        //static void Maxlngth()
        //{
        //    string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
        //    var result = names.Max(word => word.Max());

        //}


        static void string_groupby()
        {
            List<string> words = new List<string> { "basket","blueberry","chimpanze",
                                                    "abacus","banana","apple","cheese"};

            var wordGroups = words.GroupBy(x => x[0]).Select
            (y => new { FirstLetter = y.Key, words = y });

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words that start with the" + "letter '{0}':", item.FirstLetter);
                foreach (var w in item.words)
                {
                    Console.WriteLine(w);
                }
            }

        }
        //static void string_groupby_count()
        //{
        //    List<string> words = new List<string> { "basket","blueberry","chimpanze",
        //                                            "abacus","banana","apple","cheese"};

        //    var wordGroups = list4.GroupBy(x => x.Length).Select
        //    (y => new { FirstLetter = y.Key, words = y });


        //    foreach (var item in wordGroups)
        //    {
        //        Console.WriteLine("Words that has " + "'{0}' characters:", item.FirstLetter);
        //        foreach (var w in item.words)
        //        {
        //            Console.WriteLine(w);
        //        }

          //  }
       // }
    }
}
