using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_4
    {
        public void HowMany()
        {
            List<Book> books = new List<Book>()
            {
            new Book { Name = "LINQ", Year = 1970 },
            new Book { Name = "LINQ", Year = 1976 },
            new Book { Name = "Hola ", Year = 1980 },
            new Book { Name = "JQ", Year = 1982 },
            new Book { Name = "LINQ", Year = 1984 },
            new Book { Name = "LINQ", Year = 1985 },
            new Book { Name = "Jor", Year = 1988 },
            new Book { Name = "aJava", Year = 1992 }
            };

            var result = books.GroupBy(c => c.Name).Select(g => new { Author = g.Key, Count = g.Count() });

            foreach (var author in result)
            {
                Console.WriteLine("Author: " + author.Author + " Count: " + author.Count);
            }

        }
    }
}
