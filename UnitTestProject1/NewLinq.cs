using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class NewLinq
    {
            private static void Samplelist()
            {
                //The Three parts of a LINQ Query deffered execution
                //1. Data source
                List<int> numbers = new List<int>();
                numbers.Add(110);
                numbers.Add(100);
                numbers.Add(105);
                numbers.Add(102);

                //2.Query creation sql type
                var numQuery = from num in numbers
                               select num;

                //Query execution
                foreach (int num in numQuery)
                {
                    Console.Write("{0}", num);
                }
                Console.ReadLine();



            }
        }

    
}
