using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ET.Abstraction;

namespace EssentialTools.Models
{
    public class LinqValueCalculator:ILinqValueCalculator
    {
        private IDiscountHelper discHelper;
        public LinqValueCalculator(IDiscountHelper d)
        {
            discHelper = d;
        }
        public decimal Calculate(IEnumerable<Product> p)
        {
            return discHelper.ApplyDiscount( p.Sum(pr=> pr.Price));
        }
    }
}