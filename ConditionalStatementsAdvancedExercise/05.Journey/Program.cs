using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 

            string destination = "";
            string type = "";
            double spendMoney = 0;

            
            if (budget <= 100)
            {
                destination = "Bulgaria";
                
                if (season == "summer")
                {
                    spendMoney = 0.30 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = 0.70 * budget;
                    type = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                
                if (season == "summer")
                {
                    spendMoney = 0.40 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = 0.80 * budget;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendMoney = 0.90 * budget;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {spendMoney:F2}");

        }
    }
}
