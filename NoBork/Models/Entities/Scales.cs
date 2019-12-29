using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class Scales : Product
    {
        public int MaxWeight { get; set; }
        public string Fabric { get; set; }
        //public Scales(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Scales";
        //    Price = _price;
        //}
    }
}
