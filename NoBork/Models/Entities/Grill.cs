using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Grill: Product
    {
        public int MaxTemp { get; set; }
        public int ModesNumber { get; set; }
        //public Grill(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Grill";
        //    Price = _price;
        //}
    }
}
