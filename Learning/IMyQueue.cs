using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    interface IMyQueue
    {
        bool IsEmpty();
        bool IsFull();
        void Enqueue(int data);
        int Dequeue();
        int peek();
    }
}
