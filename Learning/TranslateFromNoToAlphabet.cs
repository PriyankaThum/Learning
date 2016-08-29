using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TranslateFromNoToAlphabet
    {
        public void translate()
        {
            Console.WriteLine("Enter any number");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int x = Convert.ToInt32(c[i]);
                int y = x + 48;
                char b = Convert.ToChar(y);
                Console.WriteLine(b);
            }
            

        }
    }
}
