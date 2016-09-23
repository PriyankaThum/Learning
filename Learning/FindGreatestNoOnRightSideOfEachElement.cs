using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class FindGreatestNoOnRightSideOfEachElement
    {
        public void findgreatest(int[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length-1; i++)
            {
                if (list[i] < list[i+1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
