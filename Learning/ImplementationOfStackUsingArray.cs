using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ImplementationOfStackUsingArray
    {
        public class StackArray
        {
            private int[] stack;
            private int top = -1;
            private int size;

            public StackArray()
            {
                size = 10;
                stack = new int[size];
            }

            public StackArray(int StackSize)
            {
                stack = new int[StackSize];
            }

            public bool IsEmpty()
            {
                if (top == -1)
                    return true;
                else
                    return false;
            }

            public void push(int insert)
            {
                top++;
                stack[top] = insert;
            }

            public void pop()
            {
                top--;
            }

        }
    }
}

