using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            days--;

            double price = 0;
            double finalPrice = 0;
            double discount = 0;
            double roomForOnePerson = 18;
            double apartment = 25;
            double presidentApartment = 35;

            if (room == "room for one person")
            {
                price = days * roomForOnePerson;

            }
            if (room == "apartment")
            {
                if (days < 10)
                {
                    price = days * apartment;
                    discount = price * 0.3;
                    finalPrice = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = days * apartment;
                    discount = price * 0.35;
                    finalPrice = price - discount;
                }
                else if (days > 15)
                {
                    price = days * apartment;
                    discount = price * 0.5;
                    finalPrice = price - discount;
                }
            }
            if (room == "president apartment")
            {
                if (days < 10)
                {
                    price = days * presidentApartment;
                    discount = price * 0.1;
                    finalPrice = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = days * presidentApartment;
                    discount = price * 0.15;
                    finalPrice = price - discount;
                }
                else if (days > 15)
                {
                    price = days * presidentApartment;
                    discount = price * 0.2;
                    finalPrice = price - discount;
                }
            }

            if (evaluation == "positive")
            {
                if (room == "room for one person")
                {
                    price += price * 0.25;
                    Console.WriteLine($"{price:F2}");
                }
                else if (room == "apartment" || room == "president apartment")
                {
                    finalPrice += finalPrice * 0.25;
                    Console.WriteLine($"{finalPrice:F2}");
                }
            }
            else if (evaluation == "negative")
            {
                if (room == "room for one person")
                {
                    price -= price * 0.1;
                    Console.WriteLine($"{price:F2}");
                }
                else if (room == "apartment" || room == "president apartment")
                {
                    finalPrice -= finalPrice * 0.1;
                    Console.WriteLine($"{finalPrice:F2}");
                }
            }
        }
    }
}
