using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public static class Report
    {
        public static void ReportDiscount(IBook book)
        {
            Console.WriteLine($"Tax = {Tax.TaxRate}, discount= {book.BookDiscount} price={book.PriceAfterTax()} , {book.DiscountAmount()}$ was deduced");
     
        }
        public static void ReportNoDiscount(IBook book)
        {
            Console.WriteLine($"Tax = {Tax.TaxRate}, discount= no discount , price={book.Price}");

        }
        public static void ReportSelectiveDiscount(IBook book)
        {

        Console.WriteLine($"price={(decimal)book.PriceAfterDiscount() - TotalDiscountAmount(book)}  total discount amount ={TotalDiscountAmount(book)}" );

        }
        public static void ReportSelectiveNoDiscount(double price)
        {
            Console.WriteLine($"Tax = {Tax.TaxRate}, discount= no discount , price={price}");

        }
        private static decimal TotalDiscountAmount(IBook book) { 
            return (decimal)(Discount.CalculateDiscount(book.Price) + Math.Abs(book.PriceAfterTax()-book.PriceAfterDiscount())); 
        }
    
    }
    
}
