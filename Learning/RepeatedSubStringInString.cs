using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class RepeatedSubStringInString
    {
        public void repeatedstring()
        {
            Console.WriteLine("Enter 1st String");
            string input1 = Console.ReadLine();
            char[] bigstring = input1.ToCharArray();
            Console.WriteLine("Enter 2nd string");
            string input2 = Console.ReadLine();
            char[] substring = input2.ToCharArray();
            bool flag = false;
            bool back = false;
            int position = 0;
            for (int i = 0; i < bigstring.Length; i++)
            {
                if (!flag)
                {
                    int j = 0;
                    int value = i;
                    while (j <= substring.Length - 1 && bigstring[i] == substring[j])
                    {
                        i++;
                        j++;
                        back = true;

                    }
                    if (j == substring.Length)
                    {
                        flag = true;
                        position = value;
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
                Console.WriteLine("True");
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
