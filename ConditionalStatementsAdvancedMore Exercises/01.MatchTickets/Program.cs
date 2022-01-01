using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double priceVip = 499.99d;
            double priceNormal = 249.99d;
            if (category == "Normal")
            {
                if (numberOfPeople >= 1 && numberOfPeople <= 4)
                {
                    budget = budget - budget * 0.75;
                    double moneyTickets = priceNormal * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                {
                    budget = budget - budget * 0.60;
                    double moneyTickets = priceNormal * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                {
                    budget = budget - budget * 0.50;
                    double moneyTickets = priceNormal * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                {
                    budget = budget - budget * 0.40;
                    double moneyTickets = priceNormal * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                if (numberOfPeople >= 50)
                {
                    budget = budget - budget * 0.25;
                    double moneyTickets = priceNormal * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
            }
            if (category == "VIP")
            {
                if (numberOfPeople >= 1 && numberOfPeople <= 4)
                {
                    budget = budget - budget * 0.75;
                    double moneyTickets = priceVip * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                {
                    budget = budget - budget * 0.60;
                    double moneyTickets = priceVip * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                {
                    budget = budget - budget * 0.50;
                    double moneyTickets = priceVip * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                {
                    budget = budget - budget * 0.40;
                    double moneyTickets = priceVip * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                if (numberOfPeople >= 50)
                {
                    budget = budget - budget * 0.25;
                    double moneyTickets = priceVip * numberOfPeople;
                    double moneyLeft = budget - moneyTickets;
                    if (moneyLeft >= 0)
                    {
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else
                    {
                        moneyLeft = Math.Abs(moneyLeft);
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
            }
        }
    }
}


