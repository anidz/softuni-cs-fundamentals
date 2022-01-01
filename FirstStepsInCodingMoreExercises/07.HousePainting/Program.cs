using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double hHouse = double.Parse(Console.ReadLine());
            double yWall = double.Parse(Console.ReadLine());
            double hTRoof = double.Parse(Console.ReadLine());

            double wall = hHouse * yWall;
            double window = 1.5 * 1.5;
            double twoSide = 2 * wall - 2 * window;
            double backWall = hHouse * hHouse;
            double entrance = 1.2 * 2;
            double totalFrontAndBack = 2 * backWall - entrance;
            double totalAreaWall = twoSide + totalFrontAndBack;
            double green = totalAreaWall / 3.4;

            double rectangleRoof = 2 * wall;
            double triangleRoof = 2 * (hHouse * hTRoof / 2);
            double totalAreaRoof = rectangleRoof + triangleRoof;
            double red = totalAreaRoof / 4.3;
            Console.WriteLine($"{green:F2}");
            Console.WriteLine($"{red:F2}");
        }
    }
}
