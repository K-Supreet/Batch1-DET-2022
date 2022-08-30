using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phoneno { get; set; }
       
        public string website { get; set; }
        public string Manager { get; set; }

        public override string ToString()
            
        {
            return $"Name={Name},Address={Address},Phoneno={Phoneno},website={website},Manager={Manager}";
        }

    }
}
