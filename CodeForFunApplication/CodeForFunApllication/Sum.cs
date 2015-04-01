using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeForFunApllication
{
    class Sum
    {
        //Sum and Display Multiples of 3 or 5 below 1000
        static public int sumMultiple()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum: " + sum);

            return sum;
        }
    }
}
