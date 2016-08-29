using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class MergeSort
    {
        public void merge(int[] list)
        {
            int n = list.Length;
            if (n < 2)
                return;
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = list[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i-mid] = list[i];
            }
            merge(left);
            merge(right);
            mergesort(left, right, list);
        }
        public void mergesort(int[] left, int[] right, int[] list)
        {
            int i = 0, j = 0, k = 0;
            while (i <= left.Length - 1 && j <= right.Length - 1)
            {
                if (left[i] < right[j])
                {
                    list[k] = left[i];
                    list[k + 1] = right[j];
                    i++;
                    k++;
                }
                else
                {
                    list[k] = right[j];
                    list[k + 1] = left[i];
                    k++;
                    j++;
                }

            }
            if (i > left.Length - 1)
            {
                while (j <= right.Length - 1)
                {
                    list[k] = right[j];
                    j++;
                    k++;
                }

            }
            if (j > right.Length - 1)
            {
                while (i <= left.Length - 1)
                {
                    list[k] = left[i];
                    i++;
                    k++;
                }
            }
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
