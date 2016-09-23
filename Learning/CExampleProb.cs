using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class CExampleProb
    {
        public void ex1()
        {
            //C# Program to Count the Number of 1’s in the Entered Number
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0, count = 0;
            while (n>0)
            {
                r = n % 10;
                if (r == 1)
                {
                    count++;
                }
                n = n / 10;
            }
            Console.WriteLine(count);
        }

        public void ex2()
        {
            //C# Program to Find the Frequency of the Word ʺtheʺ in a given Sentence
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the word to check the frequency");
            string w = Console.ReadLine();
            int count = 0;
            string[] words = s.Split(new char[] {' '});
            foreach (var word in words)
            {
                if (word == w)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void ex3()
        {
            //Conversion from binary to decimal
            Console.WriteLine("Enter binany number");
            int n = Convert.ToInt32(Console.ReadLine());
            int exp = 1, sum = 0;
            while (n>0)
            {
                if (n % 10 == 1)
                {

                    sum = sum + exp;
                }
                exp *= 2;
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        public void ex4()
        {
            //Conversion from decimal to binary
            Console.WriteLine("Enter decimal number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder s = new StringBuilder();
            while (n >= 1)
            {
                s.Append(n % 2);
                n /= 2;
            }
            for (int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        public void ex5()
        {
            //decimal to octal
            Console.WriteLine("Enter decimal number");
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder s = new StringBuilder();
            int x = 1;
            int temp = 0;
            while (n > x)
            {
                temp = x;
                x *= 8;
            }

            while (temp >=1)
            {
                s.Append(n / temp);
                n = n % temp;
                temp /= 8;
            }
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        public  void ex6()
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0, sum = 0, num = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("Its an Armstrong Number");
            }
            else
            {
                Console.WriteLine("Its not an Armstrong Number");
            }
        }

        public void ex7()
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Its a perfect number");
            }
            else
            {
                Console.WriteLine("Its not a perfect number");
            }
        }
    }
}
