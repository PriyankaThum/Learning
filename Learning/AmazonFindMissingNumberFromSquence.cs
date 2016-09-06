using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class AmazonFindMissingNumberFromSquence
    {
        public void missingnumber(int[] data)
        {
            int number;
            int x = data.Length + 1;
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum = sum + data[i];
            }

            number = (x * (x + 1) / 2) - sum;
            Console.WriteLine("Missing Number is " + number);
        }
    }
}
