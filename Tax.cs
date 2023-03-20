using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Price_Calculator_Kata
{
    public static class Tax
    {
        public static double TaxRate { get; set; } = 20.0;
     
        public static double CalculateTax(double price)
        {
            return (TaxRate * price / 100);
        }
       
    }
}

