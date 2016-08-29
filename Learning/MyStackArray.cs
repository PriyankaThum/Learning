using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MyStackArray : IMyStack
    {
        int[] dataArray;
        int top;
        const int DEFAULT_SIZE = 10;

        public MyStackArray()
        {
            this.top = -1;
            this.dataArray = new int[DEFAULT_SIZE];
        }

        public MyStackArray(int[] dataArray)
        {
            this.dataArray = dataArray;
            if (this.dataArray != null)
            {
                this.top = this.dataArray.Length-1;
            }
            else
            {
                this.top = -1;
                this.dataArray = new int[DEFAULT_SIZE];
            }
        }

        public bool IsEmpty()
        {
            return this.top == -1;
        }

        public bool IsFull()
        {
            return this.top == this.dataArray.Length - 1;
        }

        public int Peek()
        {
            if(!this.IsEmpty())
            {
                return this.dataArray[top];
            }
            throw new Exception("Stack is Empty");
        }

        public int Pop()
        {
            if (!this.IsEmpty())
            {
                return this.dataArray[top--];
            }
            throw new Exception("Stack is Empty");
        }

        public void Push(int data)
        {
            if(!IsFull())
            {
                this.dataArray[++top] = data;
            }
            else
            {
                throw new Exception(" Stack is Full");
            }
        }
    }
}

