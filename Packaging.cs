using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public static class Packaging
    {
        public static decimal Cost(double Price)
        {
            return (decimal)(0.01 * Price);
        }
    }
}
