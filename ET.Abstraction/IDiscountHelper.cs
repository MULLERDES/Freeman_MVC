using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.Abstraction
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal param);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize { get; set; }
        public decimal ApplyDiscount(decimal param)
        {
            return (param - (10m / (100m * param)));
        }
    }

    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            decimal discount = totalParam > 100 ? 70 : 25;
            return (totalParam - (discount / 100m * totalParam));
        }
    }

    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal param)
        {
            throw new NotImplementedException();
        }
    }
}

