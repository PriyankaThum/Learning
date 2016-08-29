using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class SelectionSort
    {
        public void selectionsort(int[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n; i++)
            {
                int m = data[i];
                for (int j = i+1; j < n ; j++)
                {
                    if (data[j] - data[i]< 0)
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            for (int a = 0; a < data.Length; a++)
            {
                Console.WriteLine(data[a]);
            }
        }
    }
}
