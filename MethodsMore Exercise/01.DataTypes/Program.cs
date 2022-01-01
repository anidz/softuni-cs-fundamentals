using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(inputInt * 2);
                    break;
                case "real":
                    double inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{inputDouble * 1.5:F2}");
                    break;
                case "string":
                    string inputString = Console.ReadLine();
                    Console.WriteLine("$" + inputString + "$");
                    break;
                default:
                    break;
            }
        }
    }
}
