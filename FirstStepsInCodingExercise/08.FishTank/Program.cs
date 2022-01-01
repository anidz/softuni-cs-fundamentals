using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volumeCm = lenght * width * height;
            double volumeLiters = volumeCm * 0.001;
            double needLiters = volumeLiters * (1 - percent * 0.01);
            Console.WriteLine(needLiters);

        }
    }
}
