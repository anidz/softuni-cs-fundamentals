using System;

namespace _03.Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int value = 1; value <= number; value +=3)
            {
                Console.WriteLine(value);
            }
        }
    }
}
