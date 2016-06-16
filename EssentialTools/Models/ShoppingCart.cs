using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private LinqValueCalculator cp;
        public ShoppingCart(LinqValueCalculator calcParam)
        {
            cp = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return cp.ValueProducts(Products);
        }
    }
}