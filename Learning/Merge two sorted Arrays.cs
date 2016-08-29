using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Merge_two_sorted_Arrays
    {
        public void merge()
        {

            int[] l = { 1, 2, 3 };
            int[] r = { 4, 5, 6 };
            int[] s = new int[l.Length + r.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i <= l.Length - 1 && j <= r.Length - 1)
            {
                if (l[i] < r[j])
                {
                    s[k] = l[i];
                    i++;
                    k++;
                }
                else
                {
                    s[k] = r[j];
                    k++;
                    j++;
                }
                
            }
            if (i > l.Length - 1)
            {
                while (j <= r.Length - 1)
                {
                    s[k] = r[j];
                    j++;
                    k++;
                }

            }
            if (j > r.Length - 1)
            {
                while (i < l.Length - 1)
                {
                    s[k] = l[i];
                    i++;
                    k++;
                }
            }
            for (int a = 0; a < s.Length; a++)
            {
                Console.WriteLine(s[a]);

            }
        }





        //public void merge()
        //{
        //    int[] a = new int[] { 1, 45, 87, 444, 999 };
        //    int[] b = new int[] { 12, 45, 45, 78, 1000, 1100 };

        //    for (int i = 0; i < a.Length; i++)
        //        b = Insert(a[i], b);

        //    for (int i = 0; i < b.Length; i++)
        //        Console.Write(b[i] + " ");
        //}

    //    public static int[] Insert(int number, int[] array)
    //{
    //    int[] c = new int[array.Length + 1];
    //    bool inserted = false;
    //    for (int i = 0, j = 0; i < array.Length; i++, j++)
    //        if (number <= array[i] && !inserted)
    //        {
    //            c[j] = number;
    //            i--;
    //            inserted = true;
    //        }
    //        else
    //        {
    //            c[j] = array[i];
    //        }
    //    if (!inserted)
    //        c[array.Length] = number;
    //    return c;
    //}






























    //public class BinaryTreeNode
    //{
    //    public BinaryTreeNode Left { get; set; }
    //    public BinaryTreeNode Right { get; set; }
    //    public int Data { get; set; }
    //    public BinaryTreeNode(int data)
    //    {
    //        this.Data = data;
    //    }
    //}
    //public void InsertIntoBST(BinaryTreeNode root, int data)
    //{
    //    BinaryTreeNode _newNode = new BinaryTreeNode(data);
    //    BinaryTreeNode _current = root;
    //    BinaryTreeNode _previous = _current;
    //    while (_current != null)
    //    {
    //        if (data < _current.Data)
    //        {
    //            _previous = _current;
    //            _current = _current.Left;
    //        }
    //        else if (data > _current.Data)
    //        {
    //            _previous = _current;
    //            _current = _current.Right;
    //        }
    //    }
    //    if (data < _previous.Data)
    //        _previous.Left = _newNode;
    //    else
    //        _previous.Right = _newNode;
    //}

    }
}

