
/*
Rotate an Array by K Positions
Problem: Write a function to rotate an array by k positions.
Example:
Input: arr = [1, 2, 3, 4, 5], k = 2
Output: [4, 5, 1, 2, 3]
Explanation: Reverse the entire array, then reverse the first k elements and the remaining elements separately.
*/
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class rotateAnArrayByK
    {
        public void rotateByK(int[]a,int K)
        {
            Array.Reverse(a);
            Array.Reverse(a,0,K);
            Array.Reverse(a,K,a.Length-K);
            Console.WriteLine(string.Join(", ",a));
        }
    }
}
