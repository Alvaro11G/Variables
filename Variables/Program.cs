using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String greeting = "Hello";
            int number = 11;
            char letter = 'A';
            bool isCodeFun = true;
            double bigNumber = 111;
            decimal deci = 10.56M;

            Console.WriteLine($"{greeting} int is {number}, char is {letter}, bool is {isCodeFun}," +
                $"double is {bigNumber}, and float is {deci}");

        }
    }
}
