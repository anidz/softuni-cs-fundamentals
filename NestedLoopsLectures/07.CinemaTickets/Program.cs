using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsTicketCounter = 0;
            int standardTicketCounter = 0;
            int kidsTicketsCounter = 0;
            int totalTicketCounter = 0;
            string movieName = Console.ReadLine();

            while(movieName != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int currTicketsForHall = 0;
                for(int i = 0; i < freePlaces; i++)
                {
                    string ticketsType = Console.ReadLine();
                    if(ticketsType == "End")
                    {
                        break;
                    }
                    if(ticketsType == "student")
                    {
                        studentsTicketCounter++;
                    }
                    else if(ticketsType == "standard")
                    {
                        standardTicketCounter++;
                    }
                    else if(ticketsType == "kid")
                    {
                        kidsTicketsCounter++;
                    }
                    totalTicketCounter++;
                    currTicketsForHall++;
                }
                double percentOfHallCinema = (currTicketsForHall * 1.0 / freePlaces * 1.0) * 100;
                Console.WriteLine($"{movieName} - {percentOfHallCinema:f2}% full.");
                movieName = Console.ReadLine();
            }
            double percentStudent = (studentsTicketCounter * 1.0 / totalTicketCounter * 1.0) * 100;
            double percentStandard = (standardTicketCounter * 1.0 / totalTicketCounter * 1.0) * 100;
            double percentKid = (kidsTicketsCounter * 1.0 / totalTicketCounter * 1.0) * 100;


            Console.WriteLine($"Total tickets: {totalTicketCounter}");
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKid:f2}% kids tickets.");

        }
    }
}
