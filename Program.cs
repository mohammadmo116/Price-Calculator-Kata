
using Price_Calculator_Kata;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

List <Book> ListOfBooks= Book.ListOfBooks();
Book book = ListOfBooks[0];

        while (true)
{
    try
    {
 
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter Tax Amount");
        double parsed;
        if (!double.TryParse(Console.ReadLine(), out parsed))
            throw new Exception("InValid Tax Value");
        Tax.TaxRate = parsed;
        Console.WriteLine($"price reported as ${book.Price} before {Tax.TaxRate}% tax and ${book.PriceAfterTax()} after {Tax.TaxRate}% tax.");
        break;
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(e.Message);
    }
}
        
Console.WriteLine("apply Discout To all Products(Yes/No) ?");
if (Console.ReadLine().ToLower().Equals("yes"))
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter Discount Amount:");
        try
        {
            double DiscountValue;
            if (!double.TryParse(Console.ReadLine(), out DiscountValue))
                throw new Exception("InValid discount Value");
            ListOfBooks = ListOfBooks.Select(c => { book.BookDiscount = DiscountValue; return c; }).ToList();
            break;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid Discount Value!");
        }
    }
    ListOfBooks.ForEach(book => {
        if (book.BookDiscount != 0)
            Report.ReportDiscount(book.BookDiscount, book.PriceAfterTax(), book.DiscountAmount());
        else
            Report.ReportNoDiscount(book.PriceAfterTax());
        });
}
    Console.WriteLine("Press Any key to exit..."); 
Console.ReadLine();

