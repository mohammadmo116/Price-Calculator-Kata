using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public interface IBookDiscount : IBook
    {
        decimal DiscountAmount();
        double PriceAfterDiscount();
        double PriceAfterTax();
        decimal TaxAmount();
    }
}
