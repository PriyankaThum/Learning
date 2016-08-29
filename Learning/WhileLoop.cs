using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class WhileLoop
    {
        public void examplewhile()
        {
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());
            while(input<5)
            {
                Console.WriteLine(input);
                input++;
            }
            System.Console.ReadLine();
        }
    }
}
