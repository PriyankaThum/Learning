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

        public void palindromefornum()
        {
            Console.WriteLine("Enter integer number");
            int input = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int n = input;
            while (input > 0)
            {
                rem = rem * 10 + input % 10;
                input /= 10;
            }

            if(n == rem)
            {
                Console.WriteLine("Given number is palindrome");
            }

            else
            {
                Console.WriteLine("Given number is not palindrome");
            }
        }


        public bool palin(string input)
        {
            
            char[] c = input.ToCharArray();
            int x = input.Length - 1;
            bool flag = false;
            for (int i = 0; i <= x - 1; i++, x--)
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
            return flag;
        }

        public void longestpalindrome()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Dictionary<string, int> d = new Dictionary<string, int>();
            string[] words = input.Split(new char[] { ' ' });
            foreach (var word in words)
            {
                if(palin(word))
                {
                    d.Add(word, word.Length);
                }
            }
            for (int i = 0; i < d.Count; i++)
            {
                int x = d.Values.ElementAt(i);
                int q = 0;
                if (x > d.Values.ElementAt(i+1))
                {
                    i++;
                }
                if(i == d.Count)
                {
                }
            }
            
        }
    }
}
