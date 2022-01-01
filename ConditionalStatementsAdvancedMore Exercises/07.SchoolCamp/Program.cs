using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            String season = Console.ReadLine();
            String typeGroup = Console.ReadLine();
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";

            switch (season)
            {
                case "Winter":
                    switch (typeGroup)
                    {
                        case "girls":
                            price = nights * students * 9.60;
                            sport = "Gymnastics";
                            break;
                        case "boys":
                            price = nights * students * 9.60;
                            sport = "Judo";
                            break;
                        case "mixed":
                            price = nights * students * 10;
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (typeGroup)
                    {
                        case "girls":
                            price = nights * students * 7.20;
                            sport = "Athletics";
                            break;
                        case "boys":
                            price = nights * students * 7.20;
                            sport = "Tennis";
                            break;
                        case "mixed":
                            price = nights * students * 9.50;
                            sport = "Cycling";
                            break;
                    }

                    break;
                
                case "Summer":
                    switch (typeGroup)
                    {
                        case "girls":
                            price = nights * students * 15;
                            sport = "Volleyball";
                            break;
                        case "boys":
                            price = nights * students * 15;
                            sport = "Football";
                            break;
                        case "mixed":
                            price = nights * students * 20;
                            sport = "Swimming";
                            break;
                    }

                    break;
                default:
                    break;
            }
            if (students >= 50)
            {
                price *= 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                price *= 0.85;
            }
            else if (students >= 10 && students < 20)
            {
                price *= 0.95;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
    }

