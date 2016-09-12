using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Reverse
    {
        public void reversestring()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            string reversedString = reversestring(input);
            string[] words = reversedString.Split(new char[] { ' ' });
            string output = string.Empty;
            foreach (string word in words)
            {
                output += reversestring(word) + " ";
            }
            Console.WriteLine(output);

        }

        public string reversestring(string inputString)
        {
            char[] c = inputString.ToCharArray();
            int x = inputString.Length - 1;
            for (int i = 0; i < x; i++, x--)
            {
                char swap = c[i];
                c[i] = c[x];
                c[x] = swap;
            }
            return new string(c);
        }
        public void rev()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            int x = input.Length - 1;
            for (int i = 0; i < x; i++, x--)
            {
                char swap = c[i];
                c[i] = c[x];
                c[x] = swap;
            }
            Console.WriteLine(new string(c));
        }
    }
}
