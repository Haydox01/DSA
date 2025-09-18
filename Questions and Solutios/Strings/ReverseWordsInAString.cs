using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions_and_Solutios
{
    public class ReverseWordsInAString
    {
        public static bool compare(int[] arr, int[] arr2){
            for(int i = 0; i <arr.Length; i++)
            {
                for (int j = 0; i < arr2.Length; i++)
                    if (arr[i] == arr[j])
                        return true;
            }
            return false;
        }
        public static string ReverseWords(string str)
        {
            List<string> words = new List<string>();
            string[] parts = str.Split('.');

            foreach (string part in parts)
            {
                if (!string.IsNullOrEmpty(part))
                {
                    words.Add(part);
                }
            }
            words.Reverse();

            return string.Join(".", words);
        }
    }
}