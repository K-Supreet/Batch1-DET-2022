using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNewOne
{
//    internal class GetSet
//    {
//        // public string Name { get; set; }

//        private string name;
//        public string Name
//        {
//        get { return name; }
//            set { name = value; }
//        }
//    }
//    class program
//    {
//        static void Main(string[] args)
//        {
//            GetSet obj = new GetSet();
//            obj.Name = "Dolu";
//            Console.WriteLine(obj.Name);
//        }
//    }


    internal class Get
    {
        public string Name { get; set; }

       
    }
    class program1
    {
        static void Main(string[] args)
        {
            Get obj = new Get();
            obj.Name = "Bolu";
            Console.WriteLine(obj.Name);
        }
    }
} 
