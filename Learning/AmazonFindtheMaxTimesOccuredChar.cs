using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class AmazonFindtheMaxTimesOccuredChar
    {
        public void charofmax()
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            int temp = 0;
            char c = 'a';
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]]++;
                }
                else
                {
                    d.Add(s[i], 1);
                }
            }
            foreach (var item in d)
            {
                if (item.Value > temp)
                {
                    temp = item.Value;
                    c = item.Key;
                }
            }
            Console.WriteLine(temp + " times repeated " + c);
        }
    }
}
