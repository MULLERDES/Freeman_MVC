using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.Abstraction
{
    public interface ILinqValueCalculator
    {
        decimal Calculate(IEnumerable<Product> p);
    }
}
