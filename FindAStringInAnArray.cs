using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class FindAStringInAnArray
    {
        public void FindNemo(string[] array)
        {
            /*foreach (var item in array)
            {
                if (item == "nemo")
                {
                    Console.WriteLine("Found nemo");
                }
            }*/
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Running");
                if (array[i] == "nemo")
                {
                    Console.WriteLine("found nemo");
                    break;
                }

                //  }//0(n) linear: Using break; helps us break out of the loop once we found nemo,
                //else it wouldve looped through all the the elements even after finding nemo
            }
        }
    }
}
