/*using BasicC_Consepts.ConditionalStatement;
using System.Runtime.Intrinsics.X86;

Find All Pairs with a Given Sum
Problem: Given an array and a target sum, find all pairs of integers in the array that add up to the target sum.
Example:
Input: arr = [2, 4, 3, 5, 6], target = 7
Output: [(2, 5), (4, 3)]
Explanation: Use a hash map to track the complement (target - current element) and check if it already exists in the array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class FindAllPairswithaGivenSum
    {
        public void AllPair(int[]a,int target)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>(); 
            for(int i = 0; i < a.Length; i++)
            {
                if (set.Contains(target - a[i]))
                {
                    Console.WriteLine($"[{target - a[i]},{a[i]}]");
                }
                else
                {
                    set.Add(a[i]);
                }
            }
            
        }
    }
}
