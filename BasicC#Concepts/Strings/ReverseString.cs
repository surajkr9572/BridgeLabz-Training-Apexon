//Reverse a String: Write a function to reverse a given string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class ReverseString
    {
        public string reverse(string str)
        {
            //char[]ch=str.ToCharArray();
            //return new string(ch.Reverse().ToArray());

            //StringBuilder sb= new StringBuilder();
            //for(int i= str.Length-1; i>=0; i--)
            //{
            //    sb.Append(str[i]);
            //}
            //return sb.ToString();

            StringBuilder sb = new StringBuilder(str);
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                char temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;
                left++;
                right--;
            }
            return sb.ToString();
        }
    }
}
