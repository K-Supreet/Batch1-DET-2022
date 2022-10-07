using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    internal class Array
    {
     public static void Main()
        {
            voting();
        }
        public static void voting()
        {
            
            int age;
            int currentyear = 2022;
            int EligibleYear;
            int[] DOB = new int[10];
            Console.WriteLine("Enter your age:");
            for (int i = 0; i < DOB.Length; i++)
            {
                DOB[i] = int.Parse(Console.ReadLine());

                age = currentyear - DOB[i];

                if (DOB[i] < 1900 || DOB[i] > 2022)
                {

                    Console.WriteLine("Voting eligible year is 0");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Eligible for voting");
                    Console.WriteLine("Year of voting is " + currentyear);
                }
                else if (age < 18)

                {
                    Console.WriteLine("not eligible for voting in 2022");
                    EligibleYear = DOB[i] + 18;
                    Console.WriteLine("Will be eligible for voting in " + EligibleYear);

                }
            }
        }
    }
}
