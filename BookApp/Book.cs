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

        /*
         * בנאי - constructor
         */
        public Book(String nameInput, int pagesInput)
        {
            name = nameInput;
            maxPage = pagesInput;
        }

        /*
         * השיטה מחזירה את העמוד הנוכחי
         */
        public int GetCurrentPage()    
        {
            return currentPage;
        }

        /*
         * השיטה קובעת עמוד נוכחי חדש
         */
        public void SetCurrentPage(int newPage)
        {
            //אם העמוד החדש בטווח בין 0 למספר עמודים בספר
            if (newPage >=0 && newPage <=maxPage)
            {
                //קבע את העמוד החדש
                currentPage = newPage;
            }
            else   //אחרת
            {
                Console.WriteLine("Cannot set page "+newPage+", it should be from 0 to "+maxPage);
            }
            
        }

        /*
         * השיטה מדפיסה את הפרטים של הספר
         * השיטה לא מחזירה כלום - void
         */
        public void PrintBookDetails()
        {
            Console.WriteLine("Book name is "+name+", it is "+maxPage+" pages long, currently I am on "+currentPage+" page!");
        }

        /*
         * השיטה "קוראת" עמוד אחד
         * השיטה מעדכנת את התכונה currentPage 
         * השיטה לא מחזירה כלום - void
         */
        public void Read()
        {
            //אם לא הגענו לעמוד האחרון בספר
            if (currentPage < maxPage)
            {
                currentPage++;
            }
            else    //אם הגענו לעמוד האחרון בספר
            {
                //לא נתקדם ונדפיס שסיימנו את הספר
                Console.WriteLine("Cannot read, the book is finished!");
            }
        }

        /*
         * השיטה "קוראת" מספר עמודים
         * השיטה מעלה את הערך של התכונה currentPage 
         * השיטה לא מחזירה כלום - void
         */
        public void Read(int pagesToRead)
        {
            if (currentPage + pagesToRead > maxPage)
            {
                int pagesLeft = GetPagesTillTheEnd();
                Console.WriteLine("Cannot read "+pagesToRead+" pages, only "+ pagesLeft+ " pages left!");
            }
            else
            {
                currentPage += pagesToRead;
            }
        }

        public int GetPagesTillTheEnd()
        {
            return maxPage - currentPage;
        }

    }
}
