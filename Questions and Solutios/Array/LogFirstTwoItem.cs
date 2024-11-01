using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LogFirstTwoItem
    {
        public void logFirstTwoBoxes(int[] boxes)
        {
            Console.WriteLine(boxes[0]);
            Console.WriteLine(boxes[1]);
        }//0(1). But 0(2) for two operations
    }
}
