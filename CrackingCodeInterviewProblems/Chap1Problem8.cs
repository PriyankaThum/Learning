    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap1Problem8
    {
        public void prob8()
        {
            Console.WriteLine("Enter main string s1");
            string inp1 = Console.ReadLine();
            Console.WriteLine("Enter substring s2");
            string inp2 = Console.ReadLine();
            string inp = inp1 + inp1;
            char[] s1 = inp.ToCharArray();
            char[] s2 = inp2.ToCharArray();
            // just to check whether it compared entire sub string.//
            StringBuilder s = new StringBuilder();
            bool flag = false;
            bool back = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (!flag)
                {
                    int j = 0;
                    int value = i;
                    while (j <= s2.Length - 1 && s1[i] == s2[j])
                    {
                        s.Append(s1[i]);
                        i++;
                        j++;
                        back = true;
                    }

                    if (j == s2.Length)
                    {
                        flag = true;
                    }
                    else if (back)
                    {
                        i = value + 1;
                        back = false;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("s2 is substring of s1 " + s);
            }
            else
            {
                Console.WriteLine("s2 is not substring of s1");
            }
        }
    }
}
