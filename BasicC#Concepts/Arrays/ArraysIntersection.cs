
/*
Find the Intersection of Two Arrays
Problem: Given two arrays, find their intersection (common elements).
Example:
Input: arr1 = [1, 2, 2, 1], arr2 = [2, 2]
Output: [2, 2]
Explanation: Use a hash map to count the occurrences of elements in one array and check for matches in the second array.
*/
using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class ArraysIntersection
    {
        public void intersection(int[]a, int[] b)
        {
            Dictionary<int, int> d1 = new Dictionary<int, int>();
            
            foreach (int i in a)
            {
                if (d1.ContainsKey(i))
                {
                    d1[i]++;
                }
                else
                {
                    d1[i] = 1;
                }
            }
            foreach (int i in b)
            {
                if (d1.ContainsKey(i))
                {
                    Console.WriteLine("Intersection elements : "+i);
                    d1[i]--;
                }
            }

        }
    }
}
