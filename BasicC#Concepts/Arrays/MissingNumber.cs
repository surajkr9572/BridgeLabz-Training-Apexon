/*Find the Missing Number in an Array
Problem: Given an array of size n-1 containing distinct numbers in the range from 1 to n, find the missing number.
Example:
Input: [1, 2, 4, 5, 6]
Output: 3
Explanation: The sum of the first n natural numbers is n*(n+1)/2. Subtract the sum of array elements from this total to find the missing number.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class MissingNumber
    {
        public int missing(int[] a,int n)
        {
            int sum = (n * (n + 1)) / 2;
            int sum1 = 0;
            foreach(int i in a)
            {
                sum1 += i;
            }
            return sum - sum1;
        }
    }
}
