using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class GuessTheNumberGame
    {
        public void guess()
        {
            Random rdn = new Random();
            int number = rdn.Next(1, 1000);
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Guess the number between 1 to 1000");
                int inp = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    if (number == inp)
                    {
                        Console.WriteLine("Zero in");
                    }
                    else if (number > inp)
                    {
                        Console.WriteLine("Too low try again");
                    }
                    else if (number < inp)
                    {
                        Console.WriteLine("To high try again");
                    }
                }
                else
                {
                    if (number == inp)
                    {
                        Console.WriteLine("Congratulations. You guessed the number");
                        Console.WriteLine("Play again : Yes/No");
                        string response = Console.ReadLine();
                        if (response == "Yes")
                        {
                            guess();
                        }
                    }
                    else
                    {
                        i = 1;
                    }
                }
            }
            


        }
    }
}
