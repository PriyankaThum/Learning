using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class SumOfTwoNumbersInArray
    {
        public void exp()
        {
            int[] c = { 1, 2, 3, 4, 5, 6, 6, 4, 7, 7, 7, 4 };
            int l = c.Length;
            Console.WriteLine("Enter 1st number");
            int x = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter 2nd number");
            int y = (Convert.ToInt32(Console.ReadLine()));
            int sum = 0;
            bool flag = false;
            for (int i = 0; i <= l-1; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    if (c[i] == x && c[j] == y)
                    {
                        if (i < j && c[j + 1] == y)
                        {
                            while (i < j)
                            {
                                sum = sum + c[i + 1];
                                i++;
                                flag = true;
                            }
                            break;                           
                        }

                        else
                        {
                            while (i < j - 1)
                            {
                                sum = sum + c[i + 1];
                                i++;
                            }
                        }
                        if (flag == false && j < i && c[i + 1] == x)
                        {
                            while (j < i)
                            {
                                sum = sum + c[j + 1];
                                j++;
                            }
                            break;
                        }

                        else
                        {
                            while (j < i - 1)
                            {
                                sum = sum + c[j + 1];
                                j++;
                            }
                        }
                    }
                }                
            }
            Console.WriteLine("Sum of numbers" + sum);
        }
    }
}
