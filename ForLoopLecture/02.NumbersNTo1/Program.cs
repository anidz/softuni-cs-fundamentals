using System;

namespace _02.NumbersNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int value = number; value >= 1; value--)
            {
                Console.WriteLine(value);
            }
        }
    }
}
