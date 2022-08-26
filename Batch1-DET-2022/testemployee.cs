using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Testemployee
    {
        public static void Main()
        {
            Emp e = new Emp(5050, "supreet", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of Experience {e.GetYearsofExp()}");
        }

    }
    }


    