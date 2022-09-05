// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

namespace UnitTestProject1
{
    internal class NewLinq
{
        public static void Main()
        {
            //The Three parts of a LINQ Query deffered execution
            //1. Data source
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2.Query creation sql type
            // var numQuery = from num in numbers
            //  select num;

            //lamda exp
                     var numQuery = numbers.Select(x => x);
           numbers.Add(200);


            //lamda exp
            //var numQuery = numbers.Where(x => x > 102);
            //Query execution
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num );
            }
            Console.ReadLine();


        }
    }
}