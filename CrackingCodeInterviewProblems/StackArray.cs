using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class StackArray
    {
        int[] array;
        int top;
        const int size = 10;
        public StackArray()
        {
            top = -1;
            this.array = new int[size];
        }

        public StackArray(int[] list)
        {
            this.array = list;
            if (array.Length != 0)
            {
                this.top = this.array.Length - 1;
            }
            else
            {
                this.top = -1;
                this.array = new int[size];
            }
        }

        public bool isempty()
        {
            return this.top == -1;
        }

        public bool isfull()
        {
            return this.top == this.array.Length - 1;
        }

        public int peek()
        {
            if (!this.isempty())
            {
                return this.array[top];
            }
            throw new Exception("Stack is empty");
        }

        public void push(int data)
        {
            if (!isfull())
            {
                array[++top] = data;
            }
            throw new Exception("Stack is full");
        }

        public int pop()
        {
            if(!isempty())
            {
                return this.array[top--];
            }
            throw new Exception("Stack is empty");
        }

        //Describe how you could use a single array to implement three stacks.

        public void threestack(int[] list)
        {
            StackArray s1 = new StackArray();
            StackArray s2 = new StackArray();
            StackArray s3 = new StackArray();
            int x = list.Length / 3;
            for (int i = 0; i < list.Length; i++)
            {
                if (i < x)
                {
                    s1.push(list[i]);
                }
                else if (i == x || i < (2*x))
                {
                    s2.push(list[i]);
                }

                else if (i >= 2*x)
                {
                    s3.push(list[i]);
                }
            }
        }
    }
}
