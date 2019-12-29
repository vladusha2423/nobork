using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Mixer : Product
    {
        public double Volume { get; set; }
        public int SpeedsNumber { get; set; }
        public int ProgramsNumber { get; set; }
        //public Mixer(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Mixer";
        //    Price = _price;
        //}
    }
}
