using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models
{
    internal class Products222
    {
        public class Passport
        {
            [Key]
            public int PassportNumber { get; set; }
            [Key]
            public string IssuingCountry { get; set; }
            public DateTime Issued { get; set; }
            public DateTime Expires { get; set; }
        }
    }
}
