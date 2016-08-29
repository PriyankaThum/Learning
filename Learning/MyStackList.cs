using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MyStackList : IMyStack
    {
        Node top;

        int current_size;
        int Max_Size = 10;

        public MyStackList()
        {
            this.top = null;
            this.current_size = 0;     
        }

        public MyStackList(int[] dataArray)
        {
            if (dataArray == null || dataArray.Length == 0)
            {
                this.top = null;
                this.current_size = 0;
                return;
            }
            for (int i = 0; i < dataArray.Length; i++)
            {
                this.Push(dataArray[i]);
            }
        }
        public bool IsEmpty()
        {
            return this.top == null;
        }

        public bool IsFull()
        {
            return this.current_size == this.Max_Size;
        }

        public int Peek()
        {
            if (!this.IsEmpty())
            {
                return this.top.value;
            }
            throw new Exception("Stack is Empty");   
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                int data = this.top.value;
                this.top = this.top.next;
                this.current_size--;
                return data;
            }
            throw new Exception("Stack is Empty");
        }

        public void Push(int data)
        {
            if (!IsFull())
            {
                var current = new Node() { value = data, next = null };
                current.next = this.top;
                this.top = current;
                this.current_size++;
            }
            else
            {
                throw new Exception(" Stack is Full");
            }
        }
    }
}
