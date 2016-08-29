using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Switch
    {
        public void exampleswitch()
        {
            Console.WriteLine("Enter any number from 1 to 3");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    {
                        Console.WriteLine("you have entered 1 ");
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("you have entered 2 ");
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("you have entered 3 ");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter from 1 to 3 ");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}
