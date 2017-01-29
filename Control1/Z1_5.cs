using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Z1_5
    {
        public void  Counter(int[] array)
        {
            int result = array.Aggregate(0, (accumulator, i) => accumulator++);
            Console.WriteLine(result);
        }

        public void Maximum(int[] array)
        {
            int maxVal = array.Aggregate(int.MinValue, (c, i) => i > c ? i : c);
            Console.WriteLine(maxVal);
        }

        public void AverageValue(int[] array)
        {
            int result = (array.Aggregate(0, (accumulator, i) => accumulator + i)) / array.Length;
            Console.WriteLine(result);
        }
    }
}
