using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FillUpArrayWithEvenNumbers
    {
        public int[] EvenArray(int n)
        {
            int[] array = new int[n / 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 2;
            }
            return array;
        }
    }
}
