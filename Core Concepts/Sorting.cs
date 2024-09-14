using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core_Concepts
{
    public class Sorting
    {
        // SELECTION SORT
        // Select minimum element from the collection
        // place selected element in appropriate position
        // repeat the process for the remaining elements
        // Selection Sort is an unstable algorithm because it does not preserve the order of equal elements
        // Time Complexity: O(n^2)

        public void SelectionSort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position])
                    {
                        position = j;
                    }
                }
                    int temp = A[i];
                    A[i] = A[position];
                    A[position] = temp;
                
            }
        }
        public void Display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

        //INSERTION SORT
        // Select one element at a time from the left of the collection
        // place the selected element in its correct position
        // After insertion every element to the left of the selected element is sorted
        // Time Complexity: O(n^2)
        // Insertion Sort is a stable algorithm because it preserves the order of equal elements

        public void InsertionSort(int[] A, int n)
        {
            for(int i = 1;  i < n; i++)
            {
                int temp = A[i];
                int position = i;
                while (position >0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position = position - 1;
                }
                A[position] = temp;
            }
        }


    }
}
