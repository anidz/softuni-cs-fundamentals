using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}
