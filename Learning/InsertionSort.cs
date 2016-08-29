using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class InsertionSort
    {
        public void Insertion(int[] c)
        {
            int n = c.Length; 
            for (int i = 1; i <= n-1; i++)
            {
                int value = c[i];
                int j = i-1;
                while (j > 0 && c[j] > value)
                {
                    c[j+1] = c[j];
                    j--;
                }
                c[j+1] = value;
            }
            for (int a = 0; a < n; a++)
            {
                Console.WriteLine(c[a]);
            }
        }
    }
}
