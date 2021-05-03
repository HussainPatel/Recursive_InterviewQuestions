using System;

namespace LeetCode_Recursion_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            var result = ReverseString.ReverserStr(str);

            Console.WriteLine("{0}", result);
            Console.ReadKey();
        }
    }
}
