using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee
    {
        int rollno;
        string name;
        string dept;
        int netsal;
        int grosssal;
        int pf;

        public Employee(int rollno, string name, string dept, int grosssal)
        {
            this.rollno = rollno;
            this.name = name;
            this.dept = dept;
            this.grosssal = grosssal;

        }
        public int GetNetSalary()
        {
            pf = 12 * grosssal / 100;
            netsal = grosssal - pf;
            return netsal;
        }

        public char GetEmpGrade()
        {
            if (GetNetSalary() > 10000)
            {
                return 'A';
            }
            else if (GetNetSalary() > 5000)
            {
                return 'b';
            }
            else return 'c';
        }
    }
}







