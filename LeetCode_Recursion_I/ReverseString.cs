using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode_Recursion_I
{
    public static class ReverseString
    {

        /// <summary>
        /// we are iterating from last to first and putting in a new array 
        /// space complexity is O(n)
        /// time complexity is O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverserStringIterative(string str)
        {
            var chArr = str.ToLower().Trim().ToCharArray();
            char[] result = new char[chArr.Length];

            int j = 0;

            /// in this case we are iterating from last to first and putting in a new array 
            for (int i = chArr.Length - 1; i >= 0; i--)
            {
                result[j] = chArr[i];
                j++;
            }

            return new string(result);
        }


        /// <summary>
        /// in this case we are using the same array to sway the items
        /// Time complexity is O (n)
        /// Space Complexity is O (1)
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseStringRecursive(string str)
        {
            char[] chArr = str.ToLower().ToCharArray();
            ReverseHelper(chArr,0,chArr.Length-1);;

            Console.WriteLine(string.Join("",chArr));

        }

        private static void ReverseHelper(char[] arr, int i, int j)
        {
            if (i > j) return;

            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            ReverseHelper(arr, i + 1, j - 1);
        }

    }
}
