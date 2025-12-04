using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts._2D_Arrays
{
    internal class SpiralMatrix
    {
        public void print(int[,] matrix,int row,int col)
        {
            int left = 0, right = col - 1;
            int top = 0, bottom = row - 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    Console.WriteLine(matrix[top, i]);
                    
                }
                top++;
                for (int i = top; i <= bottom; i++)
                {
                    Console.WriteLine(matrix[i, right]);
                   
                }
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        Console.WriteLine(matrix[bottom, i]);

                    }
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.WriteLine(matrix[i, left]);

                    }
                    left++;
                }
            }

        }
    }
}
