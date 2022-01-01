using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decorPrice = 0.1 * budget;
            double clotesPrice = countStatist * pricePerStatist;
            if(countStatist > 150)
            {
                clotesPrice = clotesPrice - 0.10 * clotesPrice;
            }
            double expenses = decorPrice + clotesPrice;
            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - budget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
        }
    }
}
