using Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap2Problem1
    {
        //Write code to remove duplicates from an unsorted linked list.
        //FOLLOW UP
        //How would you solve this problem if a temporary buffer is not allowed?
        private Node newnode;

        public void prob1(int[] data)
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < data.Length; i++)
            {
                list.AddLast(data[i]);

            }
            Dictionary<int, int> d = new Dictionary<int, int>();
            
        }
    }
}
