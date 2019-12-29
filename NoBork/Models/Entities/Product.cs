using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Power { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
        public static bool operator >=(Product p1, FilterForm i)
        {
            return p1.Price >= i.MinPrice;
        }
        public static bool operator <=(Product p1, FilterForm i)
        {
            return p1.Price <= i.MaxPrice;
        }
    }
}
