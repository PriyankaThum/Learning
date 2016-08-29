using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class permutations
    {
        public void permutationsexp()
        {
            //Console.WriteLine("Enter any string");
            //string s = Console.ReadLine();
            //char[] c = s.ToCharArray();
            //int x = s.Length;
            //int[] input;
            //input = new int[255];
            //int p = 1;
            //int q = 1;
            //for (int i = 0; i <= x-1; i++)
            //{
            //    input[s[i]] += 1;
            //    p = p * (x - i);
            //    q = q * (input[s[i]]);
            //}
            //Console.WriteLine("The no permutations is " + p / q);
            Console.WriteLine("Enter any number");
            string str1 = Console.ReadLine();
            char[] str = str1.ToCharArray();
            int count = 0;
            int numOfPermutations = str1.Length * (str1.Length - 1);
            while (count <= numOfPermutations - 1)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char c = str[i];
                    str[i] = str[i + 1];
                    str[i + 1] = c;
                    Console.WriteLine(str);
                    count++;
                }
            }
        }
    }
}
