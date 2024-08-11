using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Fibbonacci
    {
        public int[] FibonacciMethod(int n)
        {
            if (n < 1) return new int[0];
            if (n == 1) return new int[] { 0 };

            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }
    }
}
