using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _231124.ORM;

namespace _231124.app
{
    internal class APP
    {
        private List<Book> books = [];
       public void Run()
        {
            InitStore();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            var query = books
               .Where(b => b.Title.StartsWith("T"))
               .Select(b => b.Author);
            String[] authors = query.ToArray();
            Console.WriteLine("______________________________");
            Console.WriteLine(String.Join(" ", authors));   


        }
        private void LinqDemo()
        {
            books.Where(b => b.Year > 2000);

        }
        private void InitStore()
        {
            books.Add(new Book()
            {
                Author = "D. Knuth",
                Title = "Art of Programming",
                Year = 2010
            });
            books.Add(new Book()
            {
                Author = "J. Stainbeck",
                Title = "Grape of Wrath",
                Year = 2001
            });
            books.Add(new Book()
            {
                Author = "T. Shevchenko",
                Title = "Kobzar",
                Year = 1995
            });
            books.Add(new Book()
            {
                Author = "A. Shvets",
                Title = "Patterns",
                Year = 2019
            });
            books.Add(new Book()
            {
                Author = "Debertoli N.",
                Title = "36 keys",
                Year = 2005
            });
            books.Add(new Book()
            {
                Author = "F.Kafka",
                Title = "The Trial",
                Year = 1925
            });
            books.Add(new Book()
            {
                Author = "Alexandre Dumas",
                Title = "The Three Musketeers",
                Year = 1844
            });
            books.Add(new Book()
            {
                Author = "Harry Harrison",
                Title = "The steel rat",
                Year = 1998
            });
        }



    }
}
