using System;
using System.Text;

namespace Learning
{
    class RemoveDuplicateChars
    {

        public void RemoveDuplicates()
        {
            //Console.WriteLine("Enter any string");
            //string input = Console.ReadLine();
            //char[] c = input.ToCharArray();
            //int x = input.Length;
            //for (int i=0;  i < x - 1;i++)
            //{
            //    for (int j=i+1; j <= x - 1;j++)
            //    {
            //        if (c[i] == c[j])
            //        {
            //            for (int k=j; k <= x-1;k++)
            //            {
            //                if(k == x-1)
            //                {
            //                    c[k] = '\0';
            //                }
            //                else
            //                {
            //                    if(c[i]==c[k+1])
            //                    {
            //                        continue;
            //                    }
            //                    else
            //                    {
            //                        c[k] = c[k + 1];
            //                    }

            //                }
            //            }

            //        }

            //    }
            //}
            //Console.WriteLine(new string(c));



            //Console.WriteLine("Enter any string");
            //string input = Console.ReadLine();
            //char[] c = input.ToCharArray();
            //int x = input.Length;
            //for (int i = 0; i < x-1; i++)
            //{
            //    for (int j = i + 1; j <= x-1; j++)
            //    {
            //        if (c[i] == c[j])
            //        {
            //            for (int k = j; k <= x-1; k++)
            //            {
            //                if (k == x - 1)
            //                {
            //                    c[k] = '\0';
            //                }
            //                else
            //                {
            //                    while (c[j] == c[k + 1])
            //                    {
            //                        k++;
            //                    }
            //                    c[j] = c[k];
            //                }
            //            }

            //        }
            //    }
            //}
            //for (int i = 0; i < x-1; i++)
            //{
            //    for (int j = i + 1; j < x-1; j++)
            //    {
            //        if (c[i] == c[j] || c[j] == c[j + 1])
            //        {
            //            int k = j;
            //            while (j<x-1)
            //            {
            //                c[j] = c[j + 1];
            //                j++;
            //            }
            //            j = k;
            //        }
            //    }
            //}
            //Console.WriteLine(new string(c));

            //Console.WriteLine("Enter any string");
            //string input = Console.ReadLine();
            //char[] c = input.ToCharArray();
            //int x = input.Length;
            //int k = 0;

            //for (int i = 0; i <= x - 1; i++)
            //{
            //    for (int j = 0; j <= x - 1; j++)
            //    {
            //        if (c[i] == c[j])
            //        {
            //            k = j;
            //            while (j <= x - 1)
            //            {
            //                if (j == x - 1)
            //                {
            //                    c[j] = '\0';
            //                }
            //                else
            //                {
            //                    c[j] = c[j + 1];

            //                }
            //                j++;
            //            }

            //            j = k;
            //        }
            //    }
            //}
            //Console.WriteLine(new string(c));

            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            char[] r = new char[input.Length];
            StringBuilder s = new StringBuilder();
            s.Append(c[0]);
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (c[i] != r[j])
                    {
                        s.Append(c[i]);
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
