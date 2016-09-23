using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class PrintAllTheCharactetersOfstringInReverse
    {

        //print all the characters present in the given string only once in a reverse order.Time & Space complexity should not be more than O(N). 
        //e.g.
        //1)Given a string aabdceaaabbbcd
        //the output should be - dcbae 
        //2)Sample String - aaaabbcddddccbbdaaeee
        //Output - eadbc 
        //3)I/P - aaafffcccddaabbeeddhhhaaabbccddaaaa
        //O/P - adcbhef

        public void charInRev()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            bool flag = false;
            output.Append(input[input.Length - 1]);
            for (int i = input.Length-2; i >= 0; i--)
            {
                for (int j = 0; j < output.Length; j++)
                {
                    if (input[i] != output[j])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
