using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class classstudent
    {
        public class Classmain1
        {
            public static Student Student { get; private set; }

            public static void Main()
            {
                ScienceStudent Student = new ScienceStudent { regno = 12, Name = "vinay" };
                ScienceStudent sciencesubject = new ScienceStudent { physics = 59, chemistry = 60, maths = 45 };
                CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

                Console.WriteLine(sciencesubject.GetAvgMarks());
                Console.WriteLine(Commercessubject.GetAvgMarks());
            }
        }
    }
}
