using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class BreakString
    {
        public void Breakstring()
        {
            //Console.WriteLine("Enter String");
            //string input = Console.ReadLine();
            //int j = 0;
            //char[] c = input.ToCharArray();
            //Console.WriteLine("Enter Column number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (((i % x) - j) == 0)
            //    {
            //        c[i] = '\n' + c[i];
            //        j++;
            //    }
            //}

            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            int a = 0;
            int x = input.Length;
            int y = 0;
            int spacecount = 0;
            Console.WriteLine("Enter Column Name");
            int num = int.Parse(Console.ReadLine());
            for (int q = 0;  q < x - 1; q++)
            {
                if (((q % num) - a) == 0)
                {
                    spacecount++;
                }
                y = (input.Length + (spacecount * 2));

            }
            char[] s = new char[y];


            for (int i = 0; i <= x-1; i++)
            {
                if (((i% num)- a) == 0 && i > 0)
                {
                    s[i] = '\n';
                    a++;                    
                }
                else
                {
                    s[i] = c[i];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
