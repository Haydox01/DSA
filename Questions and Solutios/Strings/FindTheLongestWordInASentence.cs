using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FindTheLongestWordInASentence
    {
        public string longestEvenWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string Longestword = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (Longestword.Length < words[i].Length)
                {
                    Longestword = words[i];
                }

            }
            return Longestword;

        }

    }
}
