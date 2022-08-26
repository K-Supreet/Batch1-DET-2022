using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1-DET-2022
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

         