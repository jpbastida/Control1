using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    public class Z1_1
    {
        public void BooksSelection()
        {
            List<Book> books = new List<Book>()
            {
            new Book { Name = "Assem LINQ", Year = 1970 },
            new Book { Name = "C LINQ", Year = 1976 },
            new Book { Name = "Hola ", Year = 1980 },
            new Book { Name = "JQ", Year = 1982 },
            new Book { Name = "Mio LINQ", Year = 1984 },
            new Book { Name = "Perl LINQ", Year = 1985 },
            new Book { Name = "Jor LINQ", Year = 1988 },
            new Book { Name = "aJava LINQ", Year = 1992 }
            };

            var booksSelection = books.Where(b => b.Name.Contains("LINQ")).Where(y => y.Year % 4 == 0);

            foreach (var book in booksSelection)
            {
                Console.WriteLine($"{book.Name}, {book.Year}");
            }
        }
        
    }
}
