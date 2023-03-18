using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Price_Calculator_Kata
{
    public class BookAfterTaxDiscount : IBook
    {
        public double BookDiscount { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double ProductPrice { get; set; }
        public int UPC {get; set; }

        public BookAfterTaxDiscount(int UPC, string Name, double Price) 
        {
            this.Name = Name;
            this.Price = Price;
            this.UPC = UPC;
        }

        public double PriceAfterTax()
        {
            return Tax.CalculateTax(Price) + Price;
        }
        public decimal TaxAmount()
        {
            return (decimal)(PriceAfterTax() - Price);

        }

        public double PriceAfterDiscount()
        {

            return PriceAfterTax() - (BookDiscount * PriceAfterTax() / 100);

        }
        public decimal DiscountAmount()
        {
            return (decimal)(BookDiscount * PriceAfterTax() / 100);

        }


    }
}
