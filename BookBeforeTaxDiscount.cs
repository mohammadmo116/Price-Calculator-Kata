using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class BookBeforeTaxDiscount : IBook
    {
        public double BookDiscount { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double ProductPrice { get; set; }
        public int UPC { get; set; }

        public BookBeforeTaxDiscount(int UPC, string Name, double Price) 
        {
            this.Name = Name;
            this.Price = Price;
            this.UPC = UPC;
        }

        public double PriceAfterTax()
        {
            return Tax.CalculateTax(PriceAfterDiscount()) +PriceAfterDiscount();
        }
        public decimal TaxAmount()
        {
            return (decimal)(PriceAfterTax() - PriceAfterDiscount());

        }

        public double PriceAfterDiscount()
        {

            return Price - (BookDiscount * Price / 100);

        }
        public decimal DiscountAmount()
        {
            return (decimal)(BookDiscount * Price / 100);

        }
    }
}
