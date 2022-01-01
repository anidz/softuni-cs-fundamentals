using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side * side;
                Console.WriteLine($"{result:F3}");

            }
            else if (figure == "rectangle") 
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                result = sideA * sideB;
                Console.WriteLine($"{result:F3}");

            }
            else if (figure == "circle") 
            {
                double radius = double.Parse(Console.ReadLine());
                result = radius * radius * Math.PI;
                Console.WriteLine($"{result:F3}");

            }
            else if (figure == "triangle") 
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                result = sideA * sideB / 2;
                Console.WriteLine($"{result:F3}");                                 
                
            }
        }
    }
}
