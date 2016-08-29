using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ListSample
    {
        public void sample()
        {
            //Adding members to list
            List<string> colorList = new List<string>();

            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Purple");
            colorList.Add("Orange");

            Console.WriteLine("enter color");
            string input = Console.ReadLine();
            colorList.Add(input);
            foreach (var item in colorList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
