
using Price_Calculator_Kata;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;




List<IBook> ListOfBooks = Book.ListOfBooks();
IBook book = ListOfBooks[0];
List<IBook> ListOfBeforeTaxBooks = Book.ListOfBeforeTaxBooks();

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
        
Console.WriteLine("apply Discount To all Products(Yes/No) ?");

bool discount = Console.ReadLine().ToLower().Equals("yes");


while (true)
{
 
        try
        {
        double DiscountValue;
        if (discount)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Discount Amount:");


            if (!double.TryParse(Console.ReadLine(), out DiscountValue))
                throw new Exception("InValid discount Value");
        }
        else
            DiscountValue = 0;
        ListOfBooks.ForEach(book => {
                book.BookDiscount= DiscountValue;
            });
            break;
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid Discount Value!");
        }
    }

    ListOfBeforeTaxBooks.ForEach(book => {
        
        if(book.BookDiscount==0  )
            Report.ExpensesReportNoDiscountNoCost(book);
        else
            Report.ExpensesReport(book);
    });

    Console.WriteLine("Press Any key to exit..."); 
Console.ReadLine();

