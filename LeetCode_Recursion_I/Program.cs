using System;

namespace LeetCode_Recursion_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello World";
            //Console.WriteLine("Original string is: {0}", str);

            //Console.WriteLine(" Reverse string is: {0}", ReverseString.ReverserStringIterative(str));

            string str = "Hello World";
            Console.WriteLine("Original string is: {0}", str);

            ReverseString.ReverseStringRecursive(str);

            Console.ReadKey();
        }
    }
}
