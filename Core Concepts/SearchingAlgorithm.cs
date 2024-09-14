using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core_Concepts
{
    // linear search sequentially checks each element of the list until
    // a match is found or the whole list has been searched
    public class SearchingAlgorithm
    {
        public int LinearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                    return index;
                index += 1;
            }
            return -1;
        }

        public int LinearSearchForLoop(int[] A, int n, int key)
        {
            int index = 0;
            for(int i =0; i<n; i++)
            {
                if(A[index] == key)
                    return index;
                index += 1;
            }
            return -1;
        }

        /* Binary Search: Binary search only works if the list or array is in sorted order
        we start with middle element of the sorted array and examine the middle element with the key
         if match is found thats the one we are looking for if the key is smaller than the middle element
         then our key must be in the lower half else its in the higher half */

        // ARRAY IS SORTED ORDER
        // EXAMINE THE MIDDLE ELEMENT
        // IF MATCHES, RETURN INDEX
        //IF KEY < MIDDLE ELEMENT, SEARCH LOWER HALF
        // IF KEY IS > MIDDLE ELEMENT, SEARCH UPPER HALF

        public int BinarySearch(int[] A, int n, int key)
        {
            int l =0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (key == A[mid]) 
                    return mid;
                else if(key < A[mid])
                    r = mid - 1;
                else if (key > A[mid])
                    l = mid + 1;
            }
            return -1;
        }

        // Binary search recursive

        public int BinarySearchRecursive(int[] A, int key, int l, int r)
        {
            if(l > r) return -1;
            else
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return BinarySearchRecursive(A, key, l, mid - 1);
                else if (key > A[mid])
                    return BinarySearchRecursive(A, key, mid + 1, r);
            }
            return -1;
        }
    }
}
