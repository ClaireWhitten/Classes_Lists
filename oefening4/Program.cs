using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BookMark> bookmarks = new List<BookMark>();


            for (int i = 0; i < 5; i++)
            {
                bookmarks.Add(new BookMark());
                Console.WriteLine("Naam:");
                bookmarks[i].Naam = Console.ReadLine();
                Console.WriteLine("URL:");
                bookmarks[i].URL = Console.ReadLine();
            }

            for (int i = 0; i < bookmarks.Count; i++)
            {
                Console.WriteLine($"{i + 1}{bookmarks[i].URL}");
            }

            Console.WriteLine("Kies een nummer om de site te openen");
            int answer = Convert.ToInt32(Console.ReadLine());
            BookMark correctBookmark = bookmarks[answer - 1];
            correctBookmark.OpenSite(correctBookmark.URL);
           
            
        }
    }
}
