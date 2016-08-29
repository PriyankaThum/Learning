using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Palindrome
    {
        public void palindromeexp()
        {            
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            int x = input.Length-1;
            bool flag = false;
            for (int i = 0; i <= x-1; i++,x--)
            {
                if (c[i] == c[x])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Not a Palindrome");
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Palindrome");
            }
            
        }
    }
}
