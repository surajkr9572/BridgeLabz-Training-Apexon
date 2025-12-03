using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts._2D_Arrays
{
    internal class Multiplication2D
    {
        public void multiply(int[,]a,int[,] b,int r1,int c1,int r2,int c2)
        {
            int[,] c = new int[r1, c2];
            for(int i=0;i< r1; i++)
            {
                for(int j = 0; j < c2; j++)
                {
                    int sum = 0;
                    for(int k = 0; k < c1; k++)
                    {
                        sum += a[i,k] * b[k,j];
                    }
                    c[i,j] = sum;
                }
            }
            for(int i=0;i< r1; i++)
            {
                for(int j = 0; j < c2; j++)
                {
                    Console.Write(c[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
