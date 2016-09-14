using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap1Problem6
    {
        public void prob6()
        {
            int[,] array = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16} };
            int rows = array.GetUpperBound(0);
            int columns = array.GetUpperBound(1);
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= columns; j++)
                {
                    if (i < j)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }
            }
        }
    }
}
