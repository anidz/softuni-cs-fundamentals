using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            

            Calculate(a, b, @operator);
        }
        private static void Calculate(int a, int b, string @operator)
        {
            double result = 0;
            if (@operator == "+")
            {
                result = a + b;
                Console.WriteLine(result);
            }
            else if (@operator == "*")
            {
                result = a * b;
                Console.WriteLine(result);
            }
            else if (@operator == "/")
            {
                result = a / b;
                Console.WriteLine(result);
            }
            else if (@operator == "-")
            {
                result = a - b;
                Console.WriteLine(result);

            }

        }
    }
}
