using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Anagram
    {
        public void anagramexp()
        {
            //Console.WriteLine("Enter first string");
            //string first = Console.ReadLine();
            //char[] s = first.ToCharArray();
            //int x = first.Length;
            //Console.WriteLine("Enter second string");
            //string second = Console.ReadLine();
            //char[] t = second.ToCharArray();
            //int y = second.Length;
            //int k = 0;
            //bool flag = false;
            //for (int i = 0; i < x-1; i++)
            //{
            //    for (int j = i + 1; j <= x-1; j++)
            //    {
            //        if (s[i] > s[j])
            //        {
            //            char swap = s[i];
            //            s[i] = s[j];
            //            s[j] = swap;
            //        }
            //    }
            //}

            //for (int i = 0; i < x - 1; i++)
            //{
            //    for (int j = i + 1; j <= x - 1; j++)
            //    {
            //        if (t[i] > t[j])
            //        {
            //            char swap = t[i];
            //            t[i] = t[j];
            //            t[j] = swap;
            //        }
            //    }
            //}

            //while (k <= x-1)
            //{
            //    if (s[k] == t[k])
            //    {
            //        flag = true;
            //        k++;
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //}
            //if (flag)
            //{
            //    Console.WriteLine("Given two strings are anagram");
            //}
            //else
            //{
            //    Console.WriteLine("Given two strings are anagram");
            //}
            Console.WriteLine("Enter first string");
            string first = Console.ReadLine();
            int[] input = new int[255]; 
            char[] s = first.ToCharArray();
            int x = first.Length;
            Console.WriteLine("Enter second string");
            string second = Console.ReadLine();
            char[] t = second.ToCharArray();
            int y = second.Length;
            bool flag = false;
            if (x == y)
            {
                for (int i = 0; i <= x-1; i++)
                {
                    input[s[i]]++;
                    input[t[i]]--;
                }
                for (int i = 0; i < 255; i++)
                {
                    if (input[i] == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Not anagrams");
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("anagrams");

                }
            }
            else
            {
                Console.WriteLine("Not anagrams");
            }
            
        }
    }
}
