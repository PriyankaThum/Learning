using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MyLinkedList
    {
        private Node head;

        public MyLinkedList()
        {
            this.head = null;
        }

        public MyLinkedList(int[] data)
        {
            if(data== null || data.Length<=0)
            {
                this.head = null;
                return;
            }
            Node node = new Node() { value = data[0], next = null };
            this.head = node;
            Node current = node;
            for(int i=1;i<data.Length;i++)
            {
                node = new Node() { value = data[i], next = null };
                current.next = node;
                current = current.next;
            }
        }

        public void Insert(int data, int position)
        {
            if(position == 0)
            {
                this.InsertFirst(data);
            }
            else if(position >= this.GetListLength())
            {
                this.InsertLast(data);
            }
            else
            {
                this.InsertMiddle(data, position);
            }
            
        }

        private void InsertFirst(int data)
        {
            var current = new Node() { value = data, next = null };
            current.next = this.head;
            this.head = current;
        }

        private void InsertLast(int data)
        {
            var current = this.head;
            while (current.next != null)
            {
                current = current.next;
            }
            var node = new Node() { value = data, next = null };
            current.next = node;
        }

        private void InsertMiddle(int data, int position)
        {
            var current = this.head;
            int i = 0;
            while (i< position)
            {
                current = current.next;
                i++;
            }
            var node = new Node() { value = data, next = null };
            current.next = node;                        
        }

        public void InsertAfter(int listdata, int newdata)
        {

        }

        public void InsertBefore(int listdata, int newdata)
        {

        }


        public void remove(int position)
        {
            var current = this.head;
            int i = 0;
            Node node = new Node();
            while (i < position)
            {
                node = current;
                current = current.next;
                i++;
            }
            node.next = current.next;
            current.next = null;
            PrintList();
        }

        public void removedup()
        {
            Node current = this.head;
            while (current.next!=null)
            {
                if (current.next.value == current.value)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
                
            }
            PrintList();
        }

        public void Search(int position)
        {
            var current = this.head;
            int i = 0;
            while (i < position)
            {
                current = current.next;
                i++;
            }
            Console.WriteLine(current.value);
        }

        public void Sort()
        {

        }

        public void Reverse()
        {
            if (head.next == null)
            {
                Console.WriteLine("Only one node is present");
                return;
            }
            else
            {
                Node i = head;
                Node j = i.next;
                Node k = j.next;
                while (j != null)
                {
                    j.next = i;
                    i = j;
                    j = k;
                    if (k != null)
                    {
                        k = k.next;
                    }
                }
                if (k == null)
                {
                    j = head;
                    head.next = null;
                }

            }
        }
        public int GetListLength()
        {
            var current = this.head;
            int i = 0;
            while (current != null)
            {
                i++;
                current = current.next;
            }
            return i;
        }

        public void PrintList()
        {
            var current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
