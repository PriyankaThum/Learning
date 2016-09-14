using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap1Problem5
    {
        public void prob5()
        {
            //Write a method to replace all spaces in a string with ‘%20’.

            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    sb.Append(s[i]);
                }
                else
                {
                    sb.Append('%');
                    sb.Append('2');
                    sb.Append('0');
                }
            }
            Console.WriteLine(sb);
        }
    }
}
