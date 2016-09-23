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



        //Swap the elements in Kth position from the start and end of a link list.
        //ex: 
        //input: list: 1,2,4,5,7,8 & K=2 
        //output: 1,7,4,5,2,8
        public void reverseAtKPosition(int[] input)
        {
            Console.WriteLine("Enter the position");
            int k = Convert.ToInt32(Console.ReadLine());
            int x = input.Length - 1;
            int temp;
            for (int i = 0; i < input.Length; i++, x--)
            {
                if(i == k-1)
                {
                    temp = input[i];
                    input[i] = input[x];
                    input[x] = temp;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

    }
}
