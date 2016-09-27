using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class MyAmazonPhnInterviewQue
    {
        public string reversestring(string st)
        {
            char[] s = st.ToCharArray();
            char[] c = new Char[] { ' ', ',', '"' };
            char[] x = new char[10];
            string[] words = st.Split(c);
            string output = string.Empty;
            int i = 0;
            int k = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] < 65 ||  s[j] > 90  && s[j] < 97 || s[j] > 122)
                {
                    x[k] = s[j];
                    k++;
                }
            }
            foreach (var word in words)
            {
                output += reverse(word) + x[i];
                i++;
            }
            Console.WriteLine(output);
            return output;
        }
        public string reverse(string str)
        {
            char[] c = str.ToCharArray();
            int x = str.Length - 1;
            for (int i = 0; i < x; i++, x--)
            {
                char swap = c[i];
                c[i] = c[x];
                c[x] = swap;
            }
            return new string(c);
        }
    }
}
