using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class CenterCharacterOfArray
    {
        public void centerchar()
        {
            char[] list = new char[] {'a', 'b', 'c', 'd'};
            int x;
            if (list.Length % 2 == 0)
            {
                x = list.Length/ 2;
                Console.WriteLine("{0} {1}", list[x -1], list[x]);
            }
            else
            {
                x = list.Length/ 2;
                Console.WriteLine(list[x]);
            }
        }
    }
}
