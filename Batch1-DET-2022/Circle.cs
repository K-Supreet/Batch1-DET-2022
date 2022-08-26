using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        int r;


        public Circle(int r)
        {
            this.r = r;
        }
        public double GetRadius()
        {
            return Math.PI * r * r;
        }
    }
}

         