using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CsFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai{name}"); };

            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}," + $"you said{s2}"); };
            action.Invoke("Mary");
            action1.Invoke("Mary", " i am in Blr");
        }
     

    }
}
