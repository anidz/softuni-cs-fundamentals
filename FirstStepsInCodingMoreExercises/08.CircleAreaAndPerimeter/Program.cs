using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double Perimeter = 2 * Math.PI * r;
            Console.WriteLine($"{(area):F2}");
            Console.WriteLine($"{(Perimeter):F2}");
        }
    }
}
