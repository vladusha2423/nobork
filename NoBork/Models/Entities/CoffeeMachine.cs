using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class CoffeeMachine : Product
    {
        public int Volume { get; set; }
        public int RecipesNumber { get; set; }
        //public CoffeeMachine(string _name, int _price)
        //{
        //    Name = _name;
        //    TypeName = "Coffee machine";
        //    Price = _price;
        //}
    }
}
