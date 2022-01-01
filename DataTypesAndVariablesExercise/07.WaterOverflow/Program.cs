using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPASITY = 255;
            int n = int.Parse(Console.ReadLine());
            int totalQuantity = CAPASITY;

            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (totalQuantity - quantity >= 0)
                {
                    totalQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            int totalFilledQuantity = CAPASITY - totalQuantity;
            Console.WriteLine(totalFilledQuantity);
        }
    }
}
