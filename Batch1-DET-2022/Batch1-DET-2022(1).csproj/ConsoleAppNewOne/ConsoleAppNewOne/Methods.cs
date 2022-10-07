using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    internal class Methods
    {
        static void NewMethod(string name,int age)
        {
            Console.WriteLine(name + " is " + age);
        }
        static int Addition(int u,int v)
        {
            return u + v;
        }
        static double Addition(double u, double v)
        {
            return u + v ;
        }

        static void Main(string[] args)
        {
            NewMethod("raj", 22);
            int plus = Addition(22, 25);
            double add = Addition(1.5, 2.5);
            Console.WriteLine(plus);
            Console.WriteLine(add);
        }

      
    }
}
