using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_6
    {
        public static void AllPairs(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            var result = list1.Join(list2, l1 => true, l2 => true, (l1, l2) => new { val1 = l1, val2 = l2 });
            foreach (var item in result)
            {
                Console.Write(item.val1 + " ");
                Console.WriteLine(item.val2);
            }
        }
    }
}
