using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int countTickets = rows * cols;
            double ticketPrice = 0;

            
            switch (type)
            {
                case "Premiere": 
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
            }

            double finalSum = countTickets * ticketPrice;
            Console.WriteLine($"{finalSum:F2} leva");
        }
    }
}
