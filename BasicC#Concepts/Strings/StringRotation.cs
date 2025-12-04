//String Rotation: Check if one string is a rotation of another (e.g., "waterbottle" is a rotation of "erbottlewat").


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class StringRotation
    {
        public bool checkStringrotation(string s, string ss)
        {
            if (s.Length != ss.Length)
            {
                return false;
            }
            string temp = s + s;
            if (temp.Contains(ss))
            {
                return true;
            }
            return false;
        }
    }
}
