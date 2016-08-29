using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    interface IMyStack
    {
        void Push(int data);
        int Pop();
        int Peek();
        bool IsEmpty();
        bool IsFull();
    }
}
