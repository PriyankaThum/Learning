using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ShowUncommonCharCountOfRepeatedChar
    {
        public void hclinterview()
        {
            Console.WriteLine("Enter 1st string");
            string input1 = Console.ReadLine();
            char[] c = input1.ToCharArray();
            Console.WriteLine("Enter 2st string");
            string input2 = Console.ReadLine();
            char[] s = input2.ToCharArray();
            StringBuilder sb = new StringBuilder();
            Dictionary<char, char> d = new Dictionary<char, char>();
            for (int i = 0; i < input1.Length; i++)
            {
                d.Add(c[i], s[i]);
            }
            
            foreach (var letter in d)
            {
                if(letter.Key != letter.Value)
                {
                    sb.Append(letter.Key);
                    sb.Append(letter.Value);
                }
                else
                {
                    Console.WriteLine(letter.Key + " = 2");
                }
            }
            Console.WriteLine(sb);

        }


        public void othermethod()
        {
            Console.WriteLine("Enter 1st string");
            string input1 = Console.ReadLine();
            char[] c = input1.ToCharArray();
            Console.WriteLine("Enter 2st string");
            string input2 = Console.ReadLine();
            char[] s = input2.ToCharArray();
            StringBuilder sb = new StringBuilder();
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == s[i])
                {
                    if (d.ContainsKey(c[i]) || d.ContainsKey(s[i]))
                    {
                        d[c[i]] += 2;
                    }
                    else
                    {
                        d.Add(c[i], 2);
                    }
                }
                else
                {
                    if(!d.ContainsKey(c[i]))
                        d.Add(c[i], 0);

                    if (!d.ContainsKey(s[i]))
                        d.Add(s[i], 0);

                        sb.Append(c[i]);
                        sb.Append(s[i]);
                }

            }
            foreach (var item in d)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
