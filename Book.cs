using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Price_Calculator_Kata
{
    public class Book 
    {
        public string Name { get; set; }
        public double Price { get; set; } = 0;
        public int UPC { get; set; }
        public double ProductPrice { get; set; }
        public double BookDiscount { get; set; } = 0;

        public static List<Book> books = new List<Book>();
 

     
        public Book(int UPC, string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
            this.UPC = UPC;
        }
        public double PriceAfterTax() {
             return Tax.CalculateTax(Price) + Price;
        }
        public decimal TaxAmount()
        {
            return (decimal)(PriceAfterTax() - Price);

        }

        public double PriceAfterDiscount()
        {
           
            return PriceAfterTax() - (BookDiscount * PriceAfterTax() / 100) ;

        }
        public decimal DiscountAmount()
        {
            return (decimal)(BookDiscount * PriceAfterTax() / 100);

        }
      


        public static List<Book> ListOfBooks()
        {

            string bookname = "The Little Prince";
            int UPC = 12345;
            double price = 20.25;
            Book book = new Book(UPC, bookname, price);
            books.Add(book);
            bookname = "The Little horse";
            UPC = 123457;
            price = 15.8;
            book = new Book(UPC, bookname, price);
            books.Add(book);
            bookname = "The Little pony";
            UPC = 123941;
            price = 33.6;
            book = new Book(UPC, bookname, price);
            books.Add(book);
            bookname = "The Little tail";
            UPC = 126957;
            price = 98.2;
            book = new Book(UPC, bookname, price);
            books.Add(book);
            bookname = "The Little bee";
            UPC = 125827;
            price = 25;
            book = new Book(UPC, bookname, price);
            books.Add(book);

            return books;


        }

    }
}
