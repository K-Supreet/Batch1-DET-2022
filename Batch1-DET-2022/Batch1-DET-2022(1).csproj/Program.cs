//<<<<<<< HEAD
//﻿// See https://aka.ms/new-console-template for more information
//using ConsoleApp1;
//using System.ComponentModel.DataAnnotations;

//class MyClass
//{
//  //  enum Grade { Pass = 60, Distinction = 85 };
//    /// <summary>
//    /// method that returns Grade based on the mark
//    /// </summary>
//    /// <param name="mark">mark as the input</param>
//    /// <returns></returns>
//   /* public static string GetGrade(int mark) //IN parameter
//    {
//        if (mark >= (int)Grade.Distinction)
//            return "Distinction";
//        else if (mark >= (int)Grade.Pass)
//            return "PASS";
//        else
//            return "FAIL";
//    }
//   */
//    public static void Main()
//    {
//         try
//          {
//           /*   Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
//                                                                                                 // Console.WriteLine(m.Print());

//              Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
//              // Console.WriteLine(m1.Print());  //base class ref can point to derived object

//              Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
//           */   //Console.WriteLine(e1.Print());

//              Console.WriteLine("enter age b.w 1-120");
//              int id = Convert.ToInt32(Console.ReadLine());
//              if (id < 1 || id > 120)
//                  throw new InvalidEmpIdException("Entered age is not in the range...");

//           /*   Console.WriteLine("enter emp name");
//              string name = Console.ReadLine();

//              Console.WriteLine("enter doj");
//              DateTime doj = DateTime.Parse(Console.ReadLine());

//              Emp e2 = new(id, name, doj);


//              List<Emp> list = new List<Emp>();
//              list.Add(m);
//              list.Add(m1);
//              list.Add(e1);
//              foreach (Emp x in list)
//                  Console.WriteLine(x.Print());
//       */   }
//          catch (InvalidEmpIdException e)
//          {
//              Console.WriteLine(e.Message);
//          }
//          catch (Exception e)
//          { }
  
//      /*  CompanyManager mgr = new CompanyManager { Name = "Balaji", Surname = "R", Phoneno = "2369457825" };
//        Company company = new Company { Name = "SSL", Address = "Global city", Manager = mgr, Phoneno = "6955235697", website = "Sonata-software.com" };
//        Console.WriteLine(company.Print());
//    */

//    }
//}

//=======
//﻿// See https://aka.ms/new-console-template for more information
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1-DET-2022
//{

//     internal class Emp
//     {
//    //data declared inside class are known as "fields"
//          int id;
//          string name;
//          string dept;
//          double sal;
//          DateOnly doj;

//    //constructor - is a function used to init object data
//    //has the same name as classname, no ret type
//         public Emp(int eid, string ename, DateOnly doj)
//         {
//            id = eid; name = ename; this.doj = doj;
//         }

//    //function written inside a class is known as method
//    public int GetYearsofExp()
//       {
//        return DateTime.Now.Year - doj.Year;
//       }
//    }
//}

//>>>>>>> 1038d4121a9465b912f0f442026f37a173d61a64
