using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public static class Discount
    {
        public static double UniversalDiscount { get; set; } = 15;
        public static decimal CalculateDiscount(double price)
        {
            return (decimal)(UniversalDiscount * price / 100);

        }
    }
}
