using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    // Given 2 array, create a function that let a user know (true/false) whether these two arrays contaion any common items
    //f
    //For example 
    //const array1= ['a','b','c','d']
    //const array2= ['z','y','i']
    //Should return false
    //----------------------------------
    //const array1=['a','b','c','x']
    //const array2=['z','y','x']
    //Should return true
    //---Brute force way is O(n^2) quadatic which is nested loops
    public class CompareCommonItems
    {
       public bool ContainsCommonItem(string[] arr1, string[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        return true;
                    }
                }
            }
            return false; //0(A * B) nested for loop
        }


        public bool ContainsCommonItem2(string[] arr1, string[] arr2)
        {
            // Create a HashSet to store the items in the first array
            HashSet<string> set = new HashSet<string>();

            // Add each item in the first array to the HashSet
            for (int i = 0; i < arr1.Length; i++)
            {
                set.Add(arr1[i]);
            }

            // Loop through the second array and check if any item exists in the HashSet
            for (int j = 0; j < arr2.Length; j++)
            {
                if (set.Contains(arr2[j]))
                {
                    return true; // Return true if a common item is found
                }
            }

            return false; // Return false if no common items are found
        } //0(A + B) HashSet

        public bool ContainsCommonItemUsingList(string[] arr1, string[] arr2)
        {
            List<string> list = new List<string>(arr1);

            foreach (string item in arr2)
            {
                if (list.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }
        public bool ContainsCommonItemUsingLinq(string[] arr1, string[] arr2)
        {
            return arr1.Intersect(arr2).Any();
        }
        public bool ContainsCommonItemUsingDictionary(string[] arr1, string[] arr2)
        {
            Dictionary<string, bool> dict = new Dictionary<string, bool>();

            foreach (string item in arr1)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = true;
                }
            }

            foreach (string item in arr2)
            {
                if (dict.ContainsKey(item))
                {
                    return true;
                }
            }

            return false;
        }
        public bool ContainsCommonItemUsingSortedSet(string[] arr1, string[] arr2)
        {
            SortedSet<string> set = new SortedSet<string>(arr1);

            foreach (string item in arr2)
            {
                if (set.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}







/*Using HashSet(Optimized Approach):

Method: ContainsCommonItem2
Insertion: O(A) - Each element of arr1 is added to the HashSet, which on average takes O(1) per insertion.
Lookup: O(B) - Each element of arr2 is checked against the HashSet, which also takes O(1) per lookup on average.
Total Time Complexity: O(A + B).
Explanation: The overall time complexity is linear with respect to the sum of the lengths of both arrays.


Using List:

Method: ContainsCommonItemUsingList
Insertion: O(A) - Inserting all elements of arr1 into a List.
Lookup: O(B * A) - Each element of arr2 is checked using the Contains method on the list, which is O(A) per lookup.
Total Time Complexity: O(A + B * A), which simplifies to O(A * B).
Explanation: This method ends up being as inefficient as the brute-force method due to the linear search in the List.


Using LINQ (Intersect):

Method: ContainsCommonItemUsingLinq
Intersection: O(A + B) - The Intersect method internally uses a HashSet for the intersection operation.
Check for Any Common Items: O(1) - The.Any() method just checks if the intersection has any items.
Total Time Complexity: O(A + B).
Explanation: Similar to the HashSet approach since LINQ's Intersect leverages a HashSet internally.


Using Dictionary:

Method: ContainsCommonItemUsingDictionary
Insertion: O(A) - Inserting each element of arr1 into the Dictionary.
Lookup: O(B) - Checking if each element of arr2 exists in the Dictionary.
Total Time Complexity: O(A + B).
Explanation: The dictionary provides similar efficiency to HashSet for this problem.


Using SortedSet:

Method: ContainsCommonItemUsingSortedSet
Insertion: O(A log A) - Inserting elements into a SortedSet takes O(log A) per insertion due to maintaining the order.
Lookup: O(B log A) - Checking if elements in arr2 exist in the SortedSet also takes O(log A) per lookup.
Total Time Complexity: O(A log A + B log A).
Explanation: The SortedSet is less efficient than HashSet because of the logarithmic time complexity for insertions and lookups, but it maintains order.
*/