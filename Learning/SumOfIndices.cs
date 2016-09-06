using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class SumOfIndices
    {
        public void sumof(int[] data)
        {
            Console.WriteLine("Enter first Index");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Index");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += data[i];
            }
            Console.WriteLine(sum);
        }

        public void maxsumofindices(int[] data)
        {
            int x = data.Length;
            QuickSort q = new QuickSort();
            q.quick(data , 0, x-1);
            int sum = data[x - 1] + data[x-2];
            Console.WriteLine(sum);
        }
    }
}
