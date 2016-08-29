using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class CountOfCommonCharactersIn3Strings
    {
        public void commonchar()
        {
            Console.WriteLine("Enter 1st string: ");
            string ip1 = Console.ReadLine();
            char[] s1 = ip1.ToCharArray();
            Console.WriteLine("Enter 2st string: ");
            string ip2 = Console.ReadLine();
            char[] s2 = ip2.ToCharArray();
            Console.WriteLine("Enter 3st string: ");
            string ip3 = Console.ReadLine();
            char[] s3 = ip3.ToCharArray();
            int[] array = new int[255];
            int value = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                array[s1[i]]++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                array[s2[i]]++;
            }
            for (int i = 0; i < s3.Length; i++)
            {
                array[s3[i]]++;
            }

            for (int i = 0; i < 255; i++)
            {
                if(array[i]%3 == 0 && array[i] > 0)
                {
                    value = (array[i]/3) + value;
                }
            }
            Console.WriteLine(value);
        }
    }
}
