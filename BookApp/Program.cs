﻿namespace BookApp
{
    public class Program
    {
       public static void Main (String[] args)
        {
            //create Hobbit book
            int maxPages = 320;
            Book fiction = new Book("Hobbit", maxPages);
            fiction.PrintBookDetails();

            //read 50 pages overnight
            fiction.Read(50);
            fiction.PrintBookDetails();

            //go back to chapter 2 and read its first page
            fiction.SetCurrentPage(43);
            fiction.PrintBookDetails();
            fiction.Read();
            fiction.PrintBookDetails();

            if (fiction.isFinished())
            {
                Console.WriteLine("I finished the book!");
            }
            else
            {
                int pagesLeft = maxPages - fiction.GetCurrentPage();
                Console.WriteLine("Read " + pagesLeft + " more pages!");
            }


        }
    }

}