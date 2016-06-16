using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> prdcts)
        {
            return prdcts.Sum(p => p.Price);
        }
    }
}