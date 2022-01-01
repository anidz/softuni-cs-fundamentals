using System;

namespace _09.BurgerBus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVisitesCities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;
            for (int i = 1; i <= numberOfVisitesCities; i++)
            {
                decimal currProfit = 0;
                string nameOfCity = Console.ReadLine();
                decimal ownersIncome = decimal.Parse(Console.ReadLine());
                decimal ownerExpenses = decimal.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    ownersIncome = ownersIncome * (decimal)0.9;
                }

                else if (i % 3 == 0)
                {
                    ownerExpenses += ownerExpenses * (decimal)0.5;
                }

                currProfit = ownersIncome - ownerExpenses;
                Console.WriteLine($"In {nameOfCity} Burger Bus earned {currProfit:f2} leva.");
                totalProfit += currProfit;
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
    

