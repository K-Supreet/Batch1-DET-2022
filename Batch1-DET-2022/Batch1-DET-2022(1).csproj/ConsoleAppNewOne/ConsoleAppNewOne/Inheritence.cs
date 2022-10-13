using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
    //class Inherit
    //{
    //    public string Rainbow = "VIBGYOR";
    //    public void honk()
    //    {
    //        Console.WriteLine("Rainbow colours are:");
    //    }


    //    class Colour : Inherit
    //    {
    //        public string Time = "Rainy days";
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Colour  latest = new Colour();
    //        latest.honk();
    //        Console.WriteLine(latest.Rainbow );
    //        Console.WriteLine("And it can be seen more in " + latest.Time);
    //    }
    //}




    class Trucks
    {

        public int speed = 80 ;
        public void go()
        {

            Console.WriteLine("Info.about Trucks");
        }
        

        class Tata : Trucks
        {
            public string Name = " Tata Ace";
        }
        class Eicher:Trucks
        {
            public string Name = "Eicher Truck-Trailor";
        }
        public static void Main(string[] args)
        {
            Trucks trucks = new Trucks();
            Tata Primo = new Tata();
            Primo.go();
            Eicher Trailor = new Eicher();
            Console.WriteLine("Tata Trucks: "+ Primo.Name);
            Console.WriteLine("Max. speed is " + trucks.speed);
                 Console.WriteLine("Eicher trucks: "+Trailor.Name);
            Console.WriteLine("Max. speed is " + trucks.speed);



        }
    }
}

