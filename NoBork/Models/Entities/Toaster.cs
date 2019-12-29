using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Toaster : Product
    {
        public int ModesNumber { get; set; }
        public int FryingLevels { get; set; }
        //public Toaster(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Toaster";
        //    Price = _price;
        //}

    }
}
