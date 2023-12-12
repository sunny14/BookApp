namespace BookApp
{
    public class Program
    {
       public static void Main (String[] args)
        {
            //create Hobbit book
            Book fiction = new Book("Hobbit", 320);
            fiction.PrintBookDetails();

            //read 50 pages overnight
            fiction.Read(50);
            fiction.PrintBookDetails();

            //go back to chapter 2 (page 43) and read one page
            fiction.SetCurrentPage(43);
            fiction.PrintBookDetails();
            fiction.Read();
            fiction.PrintBookDetails();

            fiction.Read(500);

        }
    }

}