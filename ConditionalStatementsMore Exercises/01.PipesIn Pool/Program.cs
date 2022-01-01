using System;

namespace _01.PipesIn_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = p1 * hours;
            double pipe2 = p2 * hours;
            double pipePool = pipe1 + pipe2;

            if(pipePool <= volume)
            {
                double poolPercent = (pipePool / volume) * 100;
                double p1Percent = (pipe1 / pipePool) * 100;
                double p2Percent = (pipe2 / pipePool) * 100;
                Console.WriteLine($"The pool is {poolPercent:F2}% full. Pipe 1: {p1Percent:F2}%. Pipe 2: {p2Percent:F2}%.");
            }
            else if (pipePool > volume)
            {
                double overFlow = pipePool - volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {overFlow:F2} liters.");
            }
        }
    }
}
