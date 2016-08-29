using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class DistanceBetweenTwoWords
    {
        public void distancewords()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter 1st word");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd word");
            string input2 = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' });
            int value1 = 0, value2 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == input1)
                {
                    value1 = i;
                }
                if (words[i] == input2)
                {
                    value2 = i;
                }
            }          
            Console.WriteLine(value2 - value1);
        }
    }
}
