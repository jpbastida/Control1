using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_6
    {
        public void Pairs(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            var result = list1.Join(list2, l1 => true, l2 => true, (l1, l2) => new { val1 = l1, val2 = l2 });
                
            foreach (var item in result)
            {
                Console.WriteLine($"{item.val1} {item.val2}");
            }
        }

        public void NonEqualNumbersPairs(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            var result = list1.Join(list2, l1 => true, l2 => true, (l1, l2) => new { val1 = l1, val2 = l2 })
                .Where(a => a.val1 != a.val2);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.val1} {item.val2}");
            }
        }

        public void NonEqualPairs(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            var partialResult = list1.Join(list2, l1 => true, l2 => true, (l1, l2) => new { val1 = l1, val2 = l2 }); 
            var finalResult = partialResult.Where((pair, c) => !partialResult.Take(c)
                    .Any(combo => (pair.val1 == combo.val2 && pair.val2 == combo.val1)));

            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.val1} {item.val2}");
            }
        }
    }
}
