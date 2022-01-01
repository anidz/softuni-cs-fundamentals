using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArea(width, height));
        }
        static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
