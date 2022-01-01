using System;

namespace _05.Vacation
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

            if (budget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    spendMoney = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    spendMoney = 0.45 * budget;
                }
            }
            else if (budget >= 1000 && budget <= 3000)
            {
                type = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    spendMoney = 0.80 * budget;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    spendMoney = 0.60 * budget;
                }
            }
            else if (budget > 3000)
            {
                type = "Hotel";
                if (season == "Summer")
                {
                destination = "Alaska";
                spendMoney = 0.90 * budget;
                }
                else if(season == "Winter")
                {
                    destination = "Morocco";
                    spendMoney = 0.90 * budget;
                }
            }
            Console.WriteLine($"{destination} - {type} - {spendMoney:F2}");
        }
    }
}
