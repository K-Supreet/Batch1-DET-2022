using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    internal class Constructors
    {
        //public int id;
        //public string name;

        //public Constructors()
        //{
        //    id = 25;
        //    name = "Mary";
        //}
        //public static void Main ( string [] args)
        //{
        //    Constructors c = new Constructors();
        //    Console.WriteLine(c.id);
        //    Console.WriteLine(c.name);
        //}
        public string model;
        public string name;
        public int year;

        public Constructors (string modeltype,string modelname,int modelyear)
        {
            model = modeltype;
            name = modelname;
            year = modelyear;
        }
        public static void Main(string[] args)
        {
            Constructors car = new Constructors("SUV", "XUV700", 2021);
            Console.WriteLine("Car is a:"+car.model+" & name is "+ car.name );
            Console.WriteLine("And of "+car.year+" model");
        }
    }


}
