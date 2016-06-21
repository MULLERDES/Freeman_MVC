using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ET.Abstraction
{
    public class Product
    {
        public int  ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public string Category { get; set; }

    }
}