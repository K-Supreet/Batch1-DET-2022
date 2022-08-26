using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Testcircle
    {
        public static void Main()
        {
            Circle e = new Circle(5);
            Console.WriteLine($"Area of circle is {e.GetRadius()}");
        }
    }
}
