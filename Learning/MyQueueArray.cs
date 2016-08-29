using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MyQueueArray : IMyQueue
    {
        int[] dataArray;
        int front;
        int rear;
        const int DEFAULT_SIZE = 10;

        public MyQueueArray()
        {
            this.front = -1;
            this.rear = -1;
            this.dataArray = new int[DEFAULT_SIZE];
        }

        public MyQueueArray(int[] dataArray)
        {
            this.dataArray = dataArray;
            if (this.dataArray != null)
            {
                this.front = 0;
                this.rear = this.dataArray.Length - 1;
            }
            else
            {
                this.rear = -1;
                this.front = -1;
                this.dataArray = new int[DEFAULT_SIZE];
            }
        }
        public int Dequeue()
        {
            if (!IsEmpty())
            {
                return this.front = (front+1)%this.dataArray.Length;
            }
            else if (front == rear)
            {
                return this.front = -1;
            }
            else
            {
                throw new Exception("Queue is Empty");
            }
        }

        public void Enqueue(int data)
        {
            if (!IsFull())
            {
                rear = (rear+1)%this.dataArray.Length;
            }
            else if(IsEmpty())
            {
                this.front = 0;
                this.rear = 0;
            }
            else
            {
                throw new Exception("Queue is full");
            }
            this.dataArray[rear] = data;

        }

        public bool IsEmpty()
        {
            return this.front == -1 && this.rear == -1;
        }

        public bool IsFull()
        {
            return (rear+1)%this.dataArray.Length == front;
        }

        public int peek()
        {
            if (!this.IsEmpty())
            {
                return this.dataArray[front];
            }
            throw new Exception("Queue is Empty");
        }
    }
}
