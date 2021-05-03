using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    public static class NumberToZeroSquareRecursive
    {
        public static void CalualtedRecursive(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n * n);
                CalualtedRecursive(n - 1);               
            }

            
        }
    }
}
