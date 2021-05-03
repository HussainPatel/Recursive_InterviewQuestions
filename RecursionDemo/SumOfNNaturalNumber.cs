using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionDemo
{
    public static class SumOfNNaturalNumber
    {


        /// <summary>
        /// formula n(n+1) /2
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int SumofNaturalNumberRecursion(int num)
        {

            if (num == 1)
                return 1;

            num = SumofNaturalNumberRecursion(num - 1) + num;

            return num;
        }

        public static int SumofNaturalNumberIterative(int num)
        {
            int result = 0;
            while (num >= 1)
            {
                result = result + num;
                num = num - 1;
            }

            return result;
        }
    }
}
