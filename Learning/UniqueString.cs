using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class UniqueString
    {
        public void unique()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            int x = input.Length;
            bool flag = false;            
            for (int i = 0; i < x-1; i++)
            {
                for (int j = i + 1; j <= x-1; j++)
                {
                    if (c[i] == c[j])
                    {
                        flag = true;
                        break;

                    }
                    
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Unique");
            }
            else
            {


                Console.WriteLine("Not Unique");

            }

        }
    }
}
