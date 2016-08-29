using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ForLoop
    {
      

        public void examplefor()
        {
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();
            for(int i =0; i<= 10; i++)
            {
                Console.WriteLine(input);
            }
            
            
            System.Console.ReadLine();
        }
    }
}
