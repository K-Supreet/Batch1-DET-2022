using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class OrderbyLinQ
    {
      public static void Main()
        {
            Sample_Aggregate_Lambda_Simple();
             Sample_Average_Lambda();
            Sample_Count_Lambda();
            Max();
            Min();
            Sum();
            ElementAt();
            ElementAtOrDefault();
            First();
            First_Conditional();
            FirstOrDefault();
            Last();
            LastOrDefault();
            LastOrDefault_conditional();
            Sample_Single();
            SingleOrDefault();
        }

        
            // int[] numbers = { 52, 6, 02 };

            //var result = numbers.OrderBy(n => n);

            //Console.WriteLine("Ordered list of numbers:");
            //foreach (int number in result)
            //  Console.WriteLine(number);



            //var dates = new DateTime[] {
            //new DateTime(2022, 9, 1),
            //new DateTime(2022, 3, 23),
            //new DateTime(2014, 1, 25)
            //};

            //   var result = dates.OrderBy(d => d);

            //   Console.WriteLine("Ordered list of dates:");
            // foreach (DateTime dt in result)
            //    Console.WriteLine(dt.ToString("yyyy/MM/dd"));



            // string[] names = { "Ned", "Ben", "Susan" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            // foreach (string name in result)
            //    Console.WriteLine(name);

            //skip 


            // string[] words = { "one", "two", "three", "four", "five", "six" };

            // var result = words.Skip(4);

            //  Console.WriteLine("Skips the first 4 words:");
            // foreach (string word in result)
            //     Console.WriteLine(word);


            //skip while


            //string[] words = { "one", "two", "three", "four", "five" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Console.WriteLine(word);


            //Take

            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // var result = numbers.Take(5);

            //Console.WriteLine("Takes the first 5 numbers only:");
            //  foreach (int number in result)
            //    Console.WriteLine(number);

            //Takewhile

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.TakeWhile(n => n < 5);

            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            //foreach (int number in result)
            //    Console.WriteLine(number);


            //Aggrigate(simple)
            private static void Sample_Aggregate_Lambda_Simple()
        {

                var numbers = new int[] { 1, 2, 3, 4, 5 };

                var result = numbers.Aggregate((a, b) => a * b);

                Console.WriteLine("Aggrigate of numbers by multiplication:");
                Console.WriteLine(result);
            }
        static void Sample_Average_Lambda()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }
        static void Sample_Count_Lambda()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }
        static void Max()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }
        static void Min()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

           Console.WriteLine("Lowest number is:");
           Console.WriteLine(result);
        }
        static void Sum()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
        Console.WriteLine(result);
        }
        static void ElementAt()
        {
            string[] words = { "abc", "def", "ghi" };
            var result = words.ElementAt(2);
            Console.WriteLine("Element at 2 in the array is");
            Console.WriteLine(result);
        }
        static void ElementAtOrDefault()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

           Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }
        static void First()
        {
            string[] games = { "Cricket", "Hockey", "Football" };

            var result = games.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }
        static void First_Conditional()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };

            var result = countries.First(c => c.Length == 6);

            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);
        }
        static void FirstOrDefault()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };

            var result = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }
        static void Last()
        {
            int[] numbers = { 7, 3, 5 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
           Console.WriteLine(result);
        }
        static void LastOrDefault()
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
        static void LastOrDefault_conditional()
        {
            string[] words = { "one", "two", "three" };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }
        static void Sample_Single()
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
        static void SingleOrDefault()
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
    }
}
