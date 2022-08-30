//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal interface Icar
//    {
//        int GetPrice();
//    }
//    class BMW : Icar
//    {
//        public int GetPrice(string name)
//        {
//            if (name == "m3")
//                return 1300000;
//            else if (name == "X7")
//                return 7500000;
//            else
//                return 500000;

//        }
//    }

//    class Hyundai : Icar
//    {
//        public int GetPrice(String name)
//        {
//            if (name == "Creta")
//                return 2000000;
//            else if (name == "i20")
//                return 1000000;
//            else
//                return 3000000;
//        }

//    }

//    class TestCar
//    {
//        public static void Main()
//        {
//            BMW a = new BMW;
//            Hyundai ab = new Hyundai;

//            Console.WriteLine(a.GetPrice());
//            Console.WriteLine(ab.GetPrice());

//        }
//    }
//}