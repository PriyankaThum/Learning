using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap1Problem1
    {
        // Implement an algorithm to determine if a string has all unique characters.
        //What if you can not use additional data structures?
        public void prob1()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            bool flag = false;
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[i] == c[j] && i!=j)
                    {
                        Console.WriteLine("String contains duplicate characters");
                        flag = true;
                        return;
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine("String contains all unique Characters");
            }
        }
    }
}
