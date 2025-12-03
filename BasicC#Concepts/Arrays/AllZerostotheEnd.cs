
/*
Move All Zeros to the End
Problem: Write a function that moves all zeroes in an array to the end while maintaining the relative order of non-zero elements.
Example:
Input: [0, 1, 0, 3, 12]
Output: [1, 3, 12, 0, 0]
Explanation: Iterate through the array and push non-zero elements forward while keeping track of their position.
*/
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class AllZerostotheEnd
    {
        public void move(int[] a)
        {
            int n=a.Length;
            int[]an=new int[n];
            int index = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    an[index] = a[i];
                    index++;
                }
            }
            foreach(int i in an)
            {
                Console.WriteLine(i);
            }
        }
    }
}
