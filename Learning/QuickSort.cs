using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class QuickSort
    {
        public void quick(int[]list, int start, int end)
        {
            if (start<end)
            {
                int index = partition(list, start, end);
                quick(list, start, index-1);
                quick(list, index + 1, end);
            }

        }
        public int partition(int[] list, int start, int end)
        {
            int pivot = list[end];
            int index = start;
            for (int i = start; i < end; i++)
            {
                if (list[i] <= pivot)
                {
                    int t = list[i];
                    list[i] = list[index];
                    list[index] = t;
                    index++;
                }
            }
            
                int temp = list[index];
                list[index] = list[end];
                list[end] = temp;
                return index;

        }

        public void display(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
