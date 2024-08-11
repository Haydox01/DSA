using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FillUpEmptyArrayNTimes
    {
        public string[] arrayOfHiNTimes(int n)
        {
            string[] hiArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                hiArray[i] = "Hi";
            }
            return hiArray;
        }

    }
}
