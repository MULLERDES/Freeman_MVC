using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ET.Abstraction;

namespace EssentialTools.Models
{
    public class LinqValueCalculator:ILinqValueCalculator
    {
        public decimal Calculate(IEnumerable<Product> p)
        {
            return p.Sum(pr=> pr.Price);
        }
    }
}