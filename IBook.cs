namespace Price_Calculator_Kata
{
    public interface IBook
    {
        double BookDiscount { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        double ProductPrice { get; set; }
        int UPC { get; set; }

   
    }
}