using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    internal class Carclass
    {
        public static void Main(string[] args)
        {
            Car BMW = new Car();
            BMW.model = "2017";
            BMW.name = "X7";
            BMW.price = 5000000;

            Car Toyota = new Car();
            Toyota.model = "latest";
            Toyota.name = "Fortuner";
            Toyota.price = 3500000;

            Car Hyundai = new Car();
            Hyundai.model = "2022";
            Hyundai.name = "Creta";
            Hyundai.price = 2000000;

            Console.WriteLine(BMW.name);
            Console.WriteLine(Hyundai.name);
            Console.WriteLine(Toyota.model);

        }
    }
}
