using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class NameComparer : IComparer<Product>
    {
        public int Compare(Product firstObj, Product secondObj)
        {
            return firstObj.Name.CompareTo(secondObj.Name);
        }
    }
}
