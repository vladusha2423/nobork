using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Blender: Product
    {
        public double Volume { get; set; }
        public int ModesNumber { get; set; }
        //public Blender(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Blender";
        //    Price = _price;
        //}
    }
}
