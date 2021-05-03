using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
   static class NumberToZeroSquareIterative
    {

        public static void CalculateSquateIterative(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n*n);
                n--;
            }
        }

    }
}
