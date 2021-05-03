using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Recursion_I
{
    public static class ReverseString
    {
        public static string ReverserStr(string str)
        {
            var chArr = str.ToLower().Trim().ToCharArray();
            char[] result = new char[chArr.Length];
            int j = 0;
            for (int i = chArr.Length -1; i >= 0; i--)
            {
                result[j] = chArr[i];
                j++;
            }

            var res = new string(result);

            return res;
            
        }
    }
}
