using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>()
            {
                1,2,3,4,5
            };
            List<int> l2 = new List<int>()
            {
                5,4,3,2,1
            };


            // Task 1
            //Z1_1 b1 = new Z1_1();
            //b1.BooksSelection();

            // Task 2
            //Z1_2 b2 = new Z1_2();
            //b2.CountLetters();

            // Task 3
            //Z1_3 b3 = new Z1_3();
            //b3.OrderArray();

            // Task 4
            //Z1_4 b4 = new Z1_4();
            //b4.HowMany();

            // Task 5
            //int[] array = { 1, 2, 3, 4, 5 };

            //Z1_5 b5 = new Z1_5();
            //b5.Counter(array);
            //b5.Maximum(array);
            //b5.AverageValue(array);

            // Task 6
            Z1_6 b6 = new Z1_6();
            //b6.AllPairs(l1, l2);
            //b6.NonEqualNumbersPairs(l1, l2);
            b6.NonEqualPairs(l1, l2);
        }
    }
}
