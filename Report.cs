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
        public static void ReportDiscount(double discount, double price, decimal discountAmount)
        {
            Console.WriteLine($"Tax = {Tax.TaxRate}, discount= {discount} price={price} , {discountAmount}$ was deduced");
     
        }
        public static void ReportNoDiscount(double price)
        {
            Console.WriteLine($"Tax = {Tax.TaxRate}, discount= no discount , price={price}");

        }
    }
    
}
