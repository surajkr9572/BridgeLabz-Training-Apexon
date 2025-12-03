using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts._2D_Arrays
{
    internal class SumOf2Matrix
    {
        public void sum(int[,]a, int[,]b)
        {
            int n=a.GetLength(0);
            int m=a.GetLength(1);
            int[,] ans = new int[n,m];
            for(int i=0; i<n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    ans[i, j] = a[i, j] + b[i, j];
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
