using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Learning
{
    class AmazonFindMaxDimensionForGivenNum
    {
        public void maxdimension()
        {
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());
            ArrayList list = new ArrayList();
            if (input % 2 != 0)
            {
                input++;
            }
            for (int i = 1; i <= input ; i++)
            {
                if (input % i == 0)
                {
                    list.Add(i);
                }
            }
            int x = list.Capacity;
            if (x % 2 == 0)
            {
                Console.WriteLine("The max dimension is " + list[x/2] + " X " + list[(x / 2)-1]); 
            }
            else
            {
                x--;
                Console.WriteLine("The max dimension is " + list[x / 2] + " X " + list[x / 2]);
            }
        }
    }
}
