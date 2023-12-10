using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Book
    {
        private String name;
        private int maxPage;
        private int currentPage = 0;

        public Book(String nameInput, int pagesInput)
        {
            name = nameInput;
            maxPage = pagesInput;
        }

        public int GetCurrentPage()
        {
            return currentPage;
        }

        public void SetCurrentPage(int newPage)
        {
            currentPage = newPage;
        }

        public void PrintBookDetails()
        {
            Console.WriteLine("Book name is "+name+", it is "+maxPage+" pages long, currently I am on "+currentPage+" page!");
        }

        public bool isFinished()
        {
            return currentPage == maxPage;
        }

        public void Read()
        {
            if (isFinished())
            {
                Console.WriteLine("Cannot read, the book is finished!");
            }
            else
            {
                currentPage++;
            }
        }

        public void Read(int pagesToRead)
        {
            if (isFinished())
            {
                Console.WriteLine("Cannot read, the book is finished!");
            }
            else if (currentPage+pagesToRead > maxPage)
            {
                int pagesLeft = maxPage - currentPage;
                Console.WriteLine("Cannot read "+pagesToRead+" pages, only "+ pagesLeft+ " pages left!");
            }
            else
            {
                currentPage+=pagesToRead;
            }
        }

        public int GetPagesTillTheEnd()
        {
            return maxPage - currentPage;
        }

    }
}
