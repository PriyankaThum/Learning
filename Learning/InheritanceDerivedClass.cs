using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class LEDTV : TV
    {
        public override void check()
        {
            Console.WriteLine("This is a derived class");
        }
        
    }
}
