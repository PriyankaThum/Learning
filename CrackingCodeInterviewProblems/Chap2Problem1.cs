
using Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    public class Chap2Problem1
    {
        //Write code to remove duplicates from an unsorted linked list.
        //FOLLOW UP
        //How would you solve this problem if a temporary buffer is not allowed?

        NODE head;
        public Chap2Problem1()
        {
            this.head = null;
        }

        public NODE Head
        {
            get { return head; }
        }

        public Chap2Problem1(int[] list)
        {
            if (list.Length <= 0 || list == null)
            {
                this.head = null;
                return;
            }
            NODE node = new NODE() { data = list[0], next = null };
            this.head = node;
            NODE current = node;
            for (int i = 1; i < list.Length; i++)
            {
                node = new NODE() { data = list[i], next = null };
                current.next = node;
                current = current.next;
            }
        }



        public Chap2Problem1(NODE head)
        {
            if (head == null)
            {
                this.head = null;
                return;
            }
            NODE node = new NODE() { data = head.data, next = null };
            this.head = node;
            NODE current = node;
            NODE sourcecurrentNode = head;
            while (sourcecurrentNode.next != null)
            {
                sourcecurrentNode = sourcecurrentNode.next;
                node = new NODE() { data = sourcecurrentNode.data, next = null };
                current.next = node;
                current = current.next;
            }
        }

        public Chap2Problem1(Chap2Problem1 linkedList)
        {
            if (linkedList == null || linkedList.Head == null)
            {
                this.head = null;
                return;
            }
            NODE node = new NODE() { data = linkedList.Head.data, next = null };
            this.head = node;
            NODE current = node;
            NODE sourcecurrentNode = linkedList.Head;
            while (sourcecurrentNode.next != null)
            {
                sourcecurrentNode = sourcecurrentNode.next;
                node = new NODE() { data = sourcecurrentNode.data, next = null };
                current.next = node;
                current = current.next;
            }
        }

        public void insertfirst(int newdata)
        {
            NODE node = new NODE() { data = newdata, next = null };
            node.next = this.head;
            this.head = node;
        }

        public void insertmiddle(int position, int newdata)
        {
            NODE node = new NODE() { data = newdata, next = null };
            position--;
            NODE current = head;
            NODE temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = current;
                current = current.next;
            }
            node.next = current;
            temp.next = node;

        }

        public NODE insertlast(int newdata)
        {
            NODE node = new NODE() { data = newdata, next = null };
            NODE current = head;
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            return node;
        }

        public void insertafter(int newdata, int after)
        {
            NODE node = new NODE() { data = newdata, next = null };
            NODE current = head;
            while (current.data != after)
            {
                current = current.next;
            }
            node.next = current.next;
            current.next = node;
        }

        public void insertbefore(int newdata, int before)
        {
            NODE node = new NODE() { data = newdata, next = null };
            NODE current = head;
            NODE temp = head;
            while (current.data != before)
            {
                temp = current;
                current = current.next;
            }
            node.next = current;
            temp.next = node;
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

        public void remove(int value)
        {
            NODE current = this.head;
            NODE temp = head;
            while (current.data != value)
            {
                temp = current;
                current = current.next;
            }
            temp.next = current.next;
            current.next = null;
        }

        public void removeposition(int position)
        {
            NODE current = this.head;
            NODE temp = head;
            position--;
            for (int i = 0; i < position; i++)
            {
                temp = current;
                current = current.next;
            }
            temp.next = current.next;
            current.next = null;
        }

        public bool searchbyvalue(int value)
        {
            bool flag = false;
            NODE current = head;
            int position = 1;
            while (current.data != value)
            {
                position++;
                current = current.next;
            }
            if (current.data == value)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            Console.WriteLine(current.data + " " + position);
            return flag;
        }

        public void searchbyposition(int position)
        {
            NODE current = head;
            position--;
            for (int i = 0; i < position; i++)
            {
                current = current.next;
            }
            Console.WriteLine(current.data);
        }

        public void reverse()
        {
            NODE p1 = head;
            NODE p2 = p1.next;
            NODE p3 = p2.next;
            p1.next = null;
            while (p3.next != null)
            {
                p2.next = p1;
                p1 = p2;
                p2 = p3;
                p3 = p2.next;
            }
            p3.next = p2;
            p2.next = p1;
            head = p3;
        }

        public void sort()
        {
            NODE p1 = head;
            NODE p2 = p1.next;
            int temp;
            while (p1 != null)
            {
                p2 = p1.next;
                while (p2 != null)
                {
                    if (p1.data > p2.data)
                    {
                        temp = p1.data;
                        p1.data = p2.data;
                        p2.data = temp;
                    }
                    p2 = p2.next;
                }

                p1 = p1.next;
            }
        }

        public void print()
        {
            NODE current = this.head;
            while (current != null)
            {
                Console.Write(current.data);
                current = current.next;
            }
        }

        public void print(NODE node)
        {
            NODE current = node;
            while (current != null)
            {
                Console.Write(current.data);
                current = current.next;
            }

        }

        ////////////////////////////////
        // Write code to remove duplicates from an unsorted linked list.
        //FOLLOW UP
        ////How would you solve this problem if a temporary buffer is not allowed?
        public void removeduplicates()
        {
            NODE p1 = this.head;
            NODE p2 = head.next;
            NODE temp = new NODE();
            temp = p2;
            while (p1 != null)
            {
                p2 = p1.next;

                while (p2 != null)
                {
                    if (p1.data == p2.data)
                    {
                        temp.next = p2.next;
                        p2.next = null;
                    }
                    p2 = temp;
                    p2 = p2.next;
                }
                p1 = p1.next;
            }
        }
        //Implement an algorithm to find the nth to last element of a singly linked list.

        public void prob2FindnthToLastElements(int n)
        {
            NODE current = head;
            n--;
            int length = 1;
            while (current.next != null)
            {
                length++;
                current = current.next;
            }
            current = head;
            for (int i = 0; i < length; i++)
            {
                if (i >= n)
                {
                    Console.WriteLine(current.data);
                }
                current = current.next;
            }
        }

        //Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node.
        //EXAMPLE
        //Input: the node ‘c’ from the linked list a->b->c->d->e
        //Result: nothing is returned, but the new linked list looks like a->b->d->e

        public void prob3deleteusingnode(NODE node)
        {
            NODE current = head;
            NODE temp = head;
            while (current != node)
            {
                temp = current;
                current = current.next;
            }
            temp.next = current.next;
            current.next = null;
        }


        //You have two numbers represented by a linked list, where each node contains a single digit. The digits are stored in reverse order, such that the 1’s digit is at the head of the list. Write a function that adds the two numbers and returns the sum as a linked list.
        //EXAMPLE
        //Input: (3 -> 1 -> 5) + (5 -> 9 -> 2)
        //Output: 8 -> 0 -> 8

        public Chap2Problem1 prob4AddTwoLInkedList(NODE first, NODE second)
        {

            Chap2Problem1 newlist = new Chap2Problem1();
            NODE p = newlist.head;
            NODE p1 = first;
            NODE p2 = second;
            int temp = 0;
            while (p1 != null || p2 != null)
            {
                p = newlist.insertlast(p1.data + p2.data + temp);
                if (p.data > 9)
                {
                    temp = 0;
                    p.data = p.data % 10;
                    temp++;
                }
                p = p.next;
                p1 = p1.next;
                p2 = p2.next;
            }
            return newlist;
        }


        //Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
        //DEFINITION
        //Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, so as to make a loop in the linked list.
        //EXAMPLE
        //input: A -> B -> C -> D -> E -> C[the same C as earlier]
        //output: C
        public NODE StartOfLoop()
        {
            NODE p1 = this.head;
            NODE p2 = this.head;
            NODE temp = new NODE();
            bool flag = false;
            bool flag1 = false;
            int i = 0;
            while (p1 != null)
            {
                if (p1 == p2 && i > 0)
                {
                    if (flag == false)
                    {
                        p1 = this.head;
                        flag1 = true;
                        flag = true;
                    }
                    else
                    {
                        temp = p1;
                        temp.next = null;
                        return temp;
                    }
                }
                if (p1==p2)
                {
                    i++;
                }
                
                if (flag1 == true)
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
                else
                {
                    p1 = p1.next;
                    p2 = p2.next.next;
                }
            }

            return temp;
        }

        public void append(NODE a, NODE b)
        {
            NODE current = a;
            while (current.next != null)
            {
                current = current.next;
            }
            while (b != null)
            {
                current.next = b;
                current = current.next;
                b = b.next;
            }
        }

        public NODE[] SplitOriginal(int noOfLists)
        {
            int listLength = this.GetListLength();

            int splitLength = listLength / noOfLists;
            int currentLength = 1;
            NODE current = this.Head;

            while (current != null && currentLength < splitLength)
            {
                currentLength++;
                current = current.next;
            }
            if (current != null && listLength % noOfLists != 0)
                current = current.next;

            NODE temp = current.next;
            current.next = null;

            return new NODE[] { this.Head, temp };
        }

        public NODE[] Split(int noOfLists)
        {
            Chap2Problem1 cp1 = new Chap2Problem1(this.Head);

            return cp1.SplitOriginal(noOfLists);
        }

        public NODE even()
        {
            int length = this.GetListLength();
            NODE p1 = this.head;
            NODE p2 = p1.next;
            NODE p3 = p2.next;
            while (p3.next != null)
            {
                p1.next = p2.next;
                p2.next = null;
                p1 = p3;
                p2 = p1.next;
                if (p2.next != null)
                {
                    p3 = p2.next;
                }
                else
                {
                    p3 = p2;
                }
            }
            if (length % 2 == 0)
            {
                p1.next = null;
            }
            else
            {
                p1.next = p2.next;
                p2.next = null;
            }
            return this.head;
        }

        public NODE odd()
        {
            head = head.next;
            return even();
        }

        public NODE[] AlternateSplit()
        {
            Chap2Problem1 a = new Chap2Problem1(this.head);
            Chap2Problem1 b = new Chap2Problem1(this.head);
            return new NODE[] { a.even(), b.odd() };
        }

        public void frontbacksplit()
        {
            NODE current = this.head;
            NODE a = this.head;
            NODE current1 = a;
            NODE b = this.head;
            NODE current2 = b;
            NODE temp = current2;
            int length = 0, x;
            while (current != null)
            {
                length++;
                current = current.next;
            }
            current = this.head;
            if (length % 2 == 0)
            {
                x = (length / 2) - 1;
            }
            else
            {
                x = (length - 1) / 2;
            }
            int i = 0;
            while (i < x)
            {
                current1 = current1.next;
                temp = temp.next;
                current2.next = null;
                temp = current2;
                i++;
            }
            current1.next = null;
            i = 0;
            while (i < x)
            {

            }
            b = current2;
        }

        public void removedupfromsorted()
        {
            NODE current = this.head.next;
            NODE temp = this.head;
            while (current != null)
            {
                if (temp.data == current.data)
                {
                    temp.next = current.next;
                    current.next = null;
                    current = temp.next;
                }

                else
                {
                    temp = current;
                    current = current.next;

                }
            }
        }

        public void movenode(NODE a, NODE b)
        {
            NODE current1 = a;
            NODE current2 = b;
            current1.next = current2;
            current2 = current1;
            b = current2;
            print(b);
        }

        public NODE ShuffleMerge(NODE a, NODE b)
        {
            NODE p1 = a;
            NODE p2 = b;
            NODE p3 = p1.next;
            NODE p4 = p2.next;
            while (p3 != null || p4 != null)
            {
                p1.next = p2;
                p2.next = p3;
                p1 = p3;
                p3 = p1.next;
                p2 = p4;
                p4 = p2.next;
            }
            p1.next = p2;
            return a;
        }

        public NODE MakingCircularList()
        {
            NODE current = this.head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = this.head;
            return this.head;
        }

        public bool iscircular()
        {
            NODE p = this.head;
            NODE current = p.next;
            bool flag = false;
            while (current != null)
            {
                if (current == p)
                {
                    flag = true;
                    return true;
                }
                current = current.next;
            }
            return flag;
        }

        public NODE MakingCircularListInMiddle(int value)
        {
            NODE current = this.head;
            NODE p = new NODE();
            while (current.next != null)
            {
                if (current.data == value)
                    p = current;
                current = current.next;
            }
            current.next = p;
            return this.head;
        }
    }
}

