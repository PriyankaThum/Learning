using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Replacespaces
    {
        public void spaces()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            int x = input.Length;           
            int j = 1;
            int z = 0;
            int y = 0;          
            int spacecount = 0;
            

            for (int q = 0; q < x-1; q++)
            {                
                if (c[q] == ' ')
                {                    
                    spacecount++;
                }
            y = (input.Length + (spacecount*2));

            }
            char[] s = new char[y];


            for (int i = x-1; i >= 0; i--)
            {               
                if (c[i] == ' ')
                {
                    s[y - 1] = '0';
                    s[y - 2] = '2';
                    s[y - 3] = '%';
                    y = y - 3;
                }
                else
                {
                    s[y - 1] = c[i];
                    y = y - 1;

                }
            }
            Console.WriteLine(new string(s));
        }
    }
}
