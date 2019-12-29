using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Juicer : Product
    {
        public double Volume { get; set; }
        public int SpeedsNumber { get; set; }
        //public Juicer(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Juicer";
        //    Price = _price;
        //}
    }
}
