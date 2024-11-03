﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions_and_Solutios.Numbers
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            // A negative number cannot be a palindrome
            if (x < 0)
            {
                return false;
            }

            int original = x;
            int reversed = 0;

            while (x != 0)
            {
                // Get the last digit
                int digit = x % 10;

                // Check for overflow
                if (reversed > (int.MaxValue - digit) / 10)
                {
                    return false; // Overflow condition
                }

                // Update reversed
                reversed = reversed * 10 + digit;
                x /= 10; // Remove the last digit from x
            }

            return original == reversed;
        }

    }
}









/*Given an integer x, return true if x is a 
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1



Follow up: Could you solve it without converting the integer to a string?
*/