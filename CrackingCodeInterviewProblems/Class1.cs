using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Class1
    {

        public int meth()
        {
            Console.WriteLine("");
            string inputString = Console.ReadLine();
            int length = inputString.Length;
            StringBuilder prefixBuilder = new StringBuilder();
            string[] prefixArray = new string[length];
            StringBuilder suffixBuilder = new StringBuilder();
            string[] suffixArray = new string[length];
            int common = 2;
            for (int i = 0; i < length; i++)
            {
                prefixBuilder.Append(inputString[i]);
                prefixArray[i] = prefixBuilder.ToString();

                suffixBuilder.Append(inputString[length-i]);
                suffixArray[i] = new string(suffixBuilder.ToString().ToCharArray().Reverse().ToArray());
                if(prefixArray[i] == suffixArray[i])
                {
                    common++;
                }
            }
            return common;
        }
    }
}
