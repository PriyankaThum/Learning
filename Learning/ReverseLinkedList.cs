using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ReverseLinkedList
    {
        Node Head = null;
        public ReverseLinkedList(int[] list)
        {
            this.Head = new Node { value = list[0] };
            Node current = this.Head;
            for (int i = 1; i < list.Length; i++)
            {
                Node node = new Node { value = list[i] };
                current.next = node;
                current = current.next;
            }
        }
        public void Reverse()
        {
            if (Head.next == null)
            {
                Console.WriteLine("Only one node is present");
                return;
            }
            else
            {
                Node i = Head;
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
                    j = Head;
                    Head.next = null;
                }

            }
        }

        public void DisplayList()
        {
            var current = this.Head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }

        }

        public void InsertFirst(Node first)
        {
            var current = first;
            current.next = Head;
            Head = current;
            DisplayList();
        }
    }
}
