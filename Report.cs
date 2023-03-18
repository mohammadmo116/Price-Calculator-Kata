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
        public static void ExpensesReport(IBook book)
        {

            Console.WriteLine($"cost={book.Price}");
            Console.WriteLine($"Tax={book.TaxAmount()}");
            Console.WriteLine($"Packaging={Packaging.Cost(book.Price)}");
            Console.WriteLine($"Transport={book.TransportCost}");
            Console.WriteLine($"TOTAL={total(book)}");
            Console.WriteLine();
            Console.WriteLine($"TotalDiscounts={TotalDiscountAmount(book)}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
        }
        public static void ExpensesReportNoDiscountNoCost(IBook book)
        {

            Console.WriteLine($"cost={book.Price}");
            Console.WriteLine($"Tax={book.TaxAmount()}");
            Console.WriteLine($"TOTAL={total(book)}");
            Console.WriteLine();
            Console.WriteLine($"TotalDiscounts= No Discounts");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
        }
        private static decimal total(IBook book)
        {
            decimal total= (decimal)book.Price + book.TaxAmount();
            total -= TotalDiscountAmount(book);
            total+= Packaging.Cost(book.Price);
            total+= (decimal)book.TransportCost;
            return total;

        }

       
        private static decimal TotalDiscountAmount(IBook book) { 
            return (decimal)(Discount.CalculateDiscount(book.Price) + (decimal)Math.Abs(book.PriceAfterTax()-book.PriceAfterDiscount())); 
        }
    
    }
    
}
