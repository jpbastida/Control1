using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_2
    {
        public void CountLetters()
        {
            List<string> names = new List<string>()
            {
            "james", "ana", "joshep", "peter", "cintya"
            };
            string sNames = "";
            foreach (var name in names)
            {
                sNames += name;
            }

            var finalResult = sNames.GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() });

            foreach (var group in finalResult)
            {
                Console.Write(group.Letter + ": ");
                Console.WriteLine(group.Count);
            }
        }
    }
}
