using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            RaiseToPower(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }

        static void RaiseToPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}
