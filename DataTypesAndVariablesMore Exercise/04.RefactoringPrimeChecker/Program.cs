using System;
using System.Runtime.InteropServices;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int curNum = 2; curNum <= num; curNum++)
            {
                string isPrime = "true";
                for (int devider = 2; devider <= Math.Sqrt(curNum); devider++)
                {
                    if (curNum % devider == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }

                Console.WriteLine($"{curNum} -> {isPrime}");
            }
        }

       
    }
}