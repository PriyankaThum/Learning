using Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrackingCodeInterviewProblems
{
    class Chap1Problem2
    {
        //Write code to reverse a C-Style String. 
        //(C-String means that “abcd” is represented as five characters, including the null character.)
        public void prob2()
        {
            //Reverse r = new Reverse();
            //r.rev();
            Console.WriteLine("Enter any string");
            string inp = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append('\0');
            for (int i = inp.Length -1; i >= 0 ; i--)
            {
                sb.Append(inp[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
