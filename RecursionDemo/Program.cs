using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //NumberToZeroSquareIterative.CalculateSquateIterative(4);

            //NumberToZeroSquareRecursive.CalualtedRecursive(4);

            // var result = SumOfNNaturalNumbers.SumofNaturalNumberRecursion(5);
            // Console.WriteLine(result);

            //var result = SumOfNNaturalNumber.SumofNaturalNumberIterative(5);
            //Console.WriteLine(result);

            //var result = FactorialOfNumber.FactorialOfNumberIterative(5);
            //Console.WriteLine(result);

            var result = FactorialOfNumber.FactorialOfNumberRecursion(5);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
