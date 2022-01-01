using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {


            string flowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
              double price = 0;

                switch (flowers)
                {
                    case "Roses":
                        {
                            price = numberFlowers * 5;
                            if (numberFlowers > 80)
                            {
                                price *= 0.9;
                            }
                        }; break;

                    case "Dahlias":
                        {
                            price = numberFlowers * 3.8;
                            if (numberFlowers > 90)
                            {
                                price *= 0.85;
                            }
                        }; break;
                    case "Tulips":
                        {
                            price = numberFlowers * 2.8;
                            if (numberFlowers > 80)
                            {
                                price *= 0.85;
                            }
                        }; break;
                    case "Narcissus":
                        {
                            price = numberFlowers * 3;
                            if (numberFlowers < 120)
                            {
                                price *= 1.15;
                            }
                        }; break;
                    case "Gladiolus":
                        {
                            price = numberFlowers * 2.5;
                            if (numberFlowers < 80)
                            {
                                price *= 1.2;
                            }
                        }; break;
                }
                double diff = Math.Abs(price - budget);

            if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {diff:f2} leva left.");
            }

        }
    }
}
