using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_3
    {
        public void OrderArray()
        {
            int[] array = { 14, 12, 23, 20, 33, 32 };

            var result = array.OrderBy(d => d.ToString()[0]).ThenByDescending(d => d.ToString()[1]);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
