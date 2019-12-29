using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class PriceComparer: IComparer<Product>
    {
        public int Compare(Product firstObj, Product secondObj)
        {
            if (firstObj.Price > secondObj.Price)
                return 1;
            else if (firstObj.Price < secondObj.Price)
                return -1;
            else
                return 0;
        }
    }
}
