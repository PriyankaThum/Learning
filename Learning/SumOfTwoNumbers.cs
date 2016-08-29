using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class SumOfTwoNumbers
    {
        public void SumOfTwoNumbersexp()
        {
            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x = c.Length;           
            for (int i = 0; i < x-1; i++)
            {
                for (int j = i+1; j <= x-1; j++)
                {
                    if (c[i] + c[j] == 12)
                    {
                        Console.WriteLine("Sum of" + c[i] + " & " + c[j] + "is 12");
                    }
                }
            }
        }
    }
}
