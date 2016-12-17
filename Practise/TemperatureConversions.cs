using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class TemperatureConversions
    {
        public void Celsius()
        {
            Console.WriteLine("Enter the Temperature in Farenheit");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (5.0 / 9.0 * (f - 32));
            Console.WriteLine("Temperature in Celsius" + c);
        }

        public void Farenheit()
        {
            Console.WriteLine("Enter the Temperature in Celsius");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = 9.0 / 5.0 * c + 32;
            Console.WriteLine("Temperature in Farenheit" + f);
        }

        public void conversion()
        {
            Console.WriteLine("Enter ");
        }
    }
}
