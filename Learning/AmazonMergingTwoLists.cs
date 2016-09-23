using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class AmazonMergingTwoLists
    {
        public void mergelist()
        {
            int[] array1 = new int[] { 4, 3, 5, 6 };
            int[] array2 = new int[] { 6, 1, 2, 9 };
            Console.WriteLine("Enter the number");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] array3 = new int[k + k];
            for (int i = 0; i < k; i++)
            {
                array3[i] = array1[i];
                array3[i + k] = array2[i];
            }
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
    }
}
