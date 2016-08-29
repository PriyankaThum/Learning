using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class IfElse
    {
        public void exampleif()
        {
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt16(Console.ReadLine());
            if(input<5)
            {
                Console.WriteLine("You have entered a number less than 5");
            }
            else
            {
                Console.WriteLine("You have entered a number greater than 5");

            }
            System.Console.ReadLine();
        }
    }
}
