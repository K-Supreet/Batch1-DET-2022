using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class List
    {
        public static void Main()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);

            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

        }
    }

}
