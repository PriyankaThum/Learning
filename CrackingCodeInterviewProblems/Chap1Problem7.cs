using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviewProblems
{
    class Chap1Problem7
    {
        public void prob7()
        {
            int[,] array = new int[3, 3] { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 1 } };
            Dictionary<int, int> d = new Dictionary<int, int>();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                    {
                        d.Add(i, j);
                    }
                }
            }

            foreach (var item in d)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i == item.Key || j == item.Value)
                        {
                            array[i, j] = 0;
                        }
                    }
                }
            }


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.WriteLine(array[i, j]); 
            //    }
            //}
        }
    }
}
