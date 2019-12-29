using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Microwave: Product
    {
        public int WavePower { get; set; }
        public double Volume { get; set; }
        public int ProgramsNumber { get; set; }
        //public Microwave(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Blender";
        //    Price = _price;
        //}
    }
}
