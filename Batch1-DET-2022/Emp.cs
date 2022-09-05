using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Emp12
    {
       
        int id;
        string name;
        string dept;
        double sal;
        DateTime doj;

       
        public Emp12(int id, string name, DateTime doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Emp12()
        {
            id = -1; name = "no name";
        }
        public Emp12(int id, string name)
        {
            this.id = id; this.name = name;
        }

       
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }


    }
}