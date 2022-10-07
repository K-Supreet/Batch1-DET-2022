using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    public class Election
    {

        public static void Main()
        {
            Eligibility();
        }

        public static void Eligibility()
        {

            int age, DOB;          
            int currentyear = 2022;
            int EligibleYear;
            Console.WriteLine("Enter your year of birth:");
            DOB = int.Parse(Console.ReadLine());

            age = currentyear - DOB;

            if (DOB < 1900||DOB>2022)
            {

                Console.WriteLine("Voting eligible year is 0");
            }
           else if (age >= 18)
            {
                Console.WriteLine("Eligible for voting");
                Console.WriteLine("Year of voting is " +currentyear);
            }
            else if (age < 18)

            {
                Console.WriteLine("not eligible for voting in 2022");
                EligibleYear = DOB+18;
                Console.WriteLine("Will be eligible for voting in " +EligibleYear);

            }
          
            }
      }
    }


