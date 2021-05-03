using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
   public static class FactorialOfNumber
    {

        public static int FactorialOfNumberIterative(int num)
        {
            int result = 1;

            while (num >= 1)
            {
                result = result * num;
                num--;
            }

            return result;
        }

        public static int FactorialOfNumberRecursion(int num)
        {
            if (num == 1)
                return 1;

            num = num * FactorialOfNumberRecursion(num - 1);

            return num;
        }
    }
}
