using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FillUpArrayWithOddNumbers
    {
        public int[] OddArray(int n)
        {
            int[] array = new int[(n + 1) / 2]; // Calculate the required size for the array.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2 + 1; // Generate odd numbers starting from 1.
            }
            return array;
        }
    }
}
