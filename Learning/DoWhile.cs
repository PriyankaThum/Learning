using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class DoWhile
    {
        public void exampledowhile()
        {
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(" The number you have entered is" + input);
                input--;
            }
            while (input < 5);

        }
    }
}
