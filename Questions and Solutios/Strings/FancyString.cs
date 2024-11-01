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