using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int myltyplyNumber = int.Parse(Console.ReadLine());

            int sumNums = firstNumber + secondNumber;
            int devision = sumNums / divideNumber;
            int multiplication = devision * myltyplyNumber;
            Console.WriteLine(multiplication);
        }
    }
}
