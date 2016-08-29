using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ImplementationOfQueueUsingArray
    {
        public class QueueArray
        {
            private const int DefaultSize = 10;
            private int[] Queue;
            private int front;
            private int back;

            private int currentSize;
            private int totalSize;

            public QueueArray()
            {
                Queue = new int[DefaultSize];
                front = -1;
                back = -1;
                this.currentSize = 0;
                this.totalSize = DefaultSize;
            }
            public QueueArray(int queueSize)
            {
                Queue = new int[queueSize];
                front = -1;
                back = -1;
                this.currentSize = 0;
                this.totalSize = queueSize;
            }
            public QueueArray(int[] listdata)
            {
                Queue = new int[listdata.Length];
                front = -1;
                back = -1;
                this.currentSize = 0;
                this.totalSize = listdata.Length;
                for (int i = 0; i < totalSize; i++)
                {
                    Enqueue(listdata[i]);
                }
            }
            public void Enqueue(int dataItem)
            {
                if (front == -1)
                    ++front;

                if (this.currentSize < this.totalSize)
                {
                    if (back >= this.totalSize - 1)
                        back = -1;
                    Queue[++back] = dataItem;
                    this.currentSize += 1;
                }
                else
                {
                    throw new InvalidOperationException("Queue is full");
                }

            }
            public int peek()
            {
                if (this.currentSize != 0)
                {
                    return Queue[front];
                }
                else
                {
                    throw new InvalidOperationException("queue is empty");
                }
            }
            public int DeQueue()
            {
                int deQueuedItem = peek();
                front++;
                this.currentSize--;

                if (front >= this.totalSize)
                {
                    if (currentSize > 0)
                        front = 0;
                    else
                    {
                        front = -1;
                        back = -1;
                    }
                }

                return deQueuedItem;
            }

        }
    }
}
