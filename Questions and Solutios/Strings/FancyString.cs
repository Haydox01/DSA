using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions_and_Solutios.Strings
{
    public class FancyString
    {
        public string MakeFancyString(string s)
        {
            var result = new List<char>();  // Use List to build the string

            foreach (char c in s)
            {  // Loop through each character in the string
                int len = result.Count;  // Current length of result list

                // Check if last two characters are the same as current character
                if (len >= 2 && result[len - 1] == c && result[len - 2] == c)
                {
                    continue;  // Skip adding this character
                }

                // Otherwise, add the character
                result.Add(c);
            }

            // Convert the list to a string and return it
            return new string(result.ToArray());
        }
    }
}

/* QUESTION BELOW 

A fancy string is a string where no three consecutive characters are equal.

Given a string s, delete the minimum possible number of characters from s to make it fancy.

Return the final string after the deletion. It can be shown that the answer will always be unique.

 

Example 1:

Input: s = "leeetcode"
Output: "leetcode"
Explanation:
Remove an 'e' from the first group of 'e's to create "leetcode".
No three consecutive characters are equal, so return "leetcode".
Example 2:

Input: s = "aaabaaaa"
Output: "aabaa"
Explanation:
Remove an 'a' from the first group of 'a's to create "aabaaaa".
Remove two 'a's from the second group of 'a's to create "aabaa".
No three consecutive characters are equal, so return "aabaa".
Example 3:

Input: s = "aab"
Output: "aab"
Explanation: No three consecutive characters are equal, so return "aab".*/