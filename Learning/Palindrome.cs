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


        public string palin(string input)
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
                    input = "false";
                    break;
                }
            }
            return input;
        }

        public void longestpalindrome()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Dictionary<int, string> d = new Dictionary<int, string>();
            int temp = 0;
            string[] words = input.Split(new char[] { ' ' });
            foreach (var word in words)
            {
                if (palin(word) != "false")
                {
                    d.Add(word.Length, word);
                }

            }
            foreach (var item in d)
            {
                if (item.Key > temp)
                {
                    temp = item.Key;
                }
            }
            
            Console.WriteLine(d[temp] + " is the longest Palindrome in the string");
        }
    }
}
