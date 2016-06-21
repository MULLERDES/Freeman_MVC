using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ET.Abstraction;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private ILinqValueCalculator cp;
        public ShoppingCart(ILinqValueCalculator calcParam)
        {
            cp = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return cp.Calculate(Products);
        }
    }
}