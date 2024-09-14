using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core_Concepts
{
    public class Recursion
    {
        public void CalculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }
        // TAIL RECURSION
        public void CalculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursive(n - 1);
            }
        }

        // HEAD RECURSION
        public void CalculateHeadRecursive(int n)
        {
            if (n > 0)
            {
                CalculateHeadRecursive(n - 1);
                int k = n * n;
                Console.WriteLine(k);

            }
        }

        // TREE RECURSION
        public void CalculateTreeRecursive(int n)
        {
            if (n > 0)
            {
                CalculateTreeRecursive(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                CalculateTreeRecursive(n - 1);

            }

        }

        // SUM OF N NUMBERS
        public int SumOfNumbers(int n)
        {
            if (n == 0)
                return 0;
            return SumOfNumbers(n - 1) + n;
        }

        // SUM OF N USING FORMULA
        public int SumN(int n)
        {
            return n * (n + 1) / 2;
        }

        //FACTORIAL OF N USING RECURSION

        public int FactorialOfN(int n)
        {
            if (n == 0)
                return 1;
            return FactorialOfN(n - 1) * n;
        }

        //FACTORIAL OF N USING LOOP

        public int FactorialOfNUsingLoop(int n)
        {
            int Factorial = 1;
            for(int i =1; i<=n; i++)
            {
                Factorial = Factorial * i;
            }
            return Factorial;
        }
    }
}
