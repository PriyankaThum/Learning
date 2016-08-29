using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class BubbleSort
    {
        public void IntArrayBubbleSort(int[] data)
        {
            int N = data.Length;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N-j-1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
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
