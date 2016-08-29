using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class stringtoint
    {
        public void stringtointexp()
        {
            //Console.WriteLine("Enter any string");
            //string input = Console.ReadLine();            

            //int x = input.Length;            
            //int[] c;
            //c = new int[255];
            //for (int i = 0; i < x; i++)
            //{
            //    c[input[i]] = input[i];
            //}
            Console.WriteLine("Enter a Number");
            int numb = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (numb > 0)
            {
                int rem = numb % 10;
                reverse = (reverse * 10) + rem;
                numb = numb / 10;

            }
            Console.WriteLine("Reverse number={0}", reverse);
            Console.ReadLine();
        }
    }
}
