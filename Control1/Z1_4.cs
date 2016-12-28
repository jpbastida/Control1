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
            new Book { Name = "Jor LINQ", Year = 1988 },
            new Book { Name = "aJava LINQ", Year = 1992 }
            };

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            var q = from b in books
                    group b by b.Name into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            }

        }
    }
}
