using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TryCatch
    {
        public static void StaticSample1()
        {
            Console.WriteLine("enter name");
            string input = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("enter valid name ");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            System.Console.ReadLine();

        }

        public void Sample1()
        {
            Console.WriteLine("enter the name");
            string input = Console.ReadLine();
            try
            {
                if (input.Length == 0)
                {
                    Console.WriteLine("enter valid name ");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            System.Console.ReadLine();

        }


    }
}




