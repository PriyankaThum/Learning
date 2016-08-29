using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class FibonacciSeries
    {
        public void fibonacci()
        {
            Console.WriteLine("Enter the length of fibonacci series");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            Console.Write("{0} {1}", a, b + " ");
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
        }
    }
}
