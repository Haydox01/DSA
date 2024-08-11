using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrintAllPairOfAnArray
    {
        public void logAllPairsOfArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + array[j]);
                }
            }
        }
    }
}
