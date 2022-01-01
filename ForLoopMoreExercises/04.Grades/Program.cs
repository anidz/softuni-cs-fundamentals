using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int greaterThanFive = 0;
            int betweenFourAndFive = 0;
            int betweenThreeAndFour = 0;
            int PoorerThanThree = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double gradeInput = double.Parse(Console.ReadLine());
                if (gradeInput >= 5.00)
                {
                    greaterThanFive++;
                }

                if (gradeInput >= 4.00 && gradeInput <= 4.99)
                {
                    betweenFourAndFive++;
                }
                   
                if (gradeInput >= 3.00 && gradeInput <= 3.99)
                {
                    betweenThreeAndFour++;
                }
                    
                if (gradeInput < 3.00)
                {
                    PoorerThanThree++;
                }
                    
                average += gradeInput;
            }
            double per1 = greaterThanFive * 1.0 / students *100;
            double per2 = betweenFourAndFive * 1.0 / students * 100;
            double per3 = betweenThreeAndFour * 1.0 / students * 100;
            double per4 = PoorerThanThree * 1.0 / students * 100;
            double per5 = average * 1.0 / students;


            
            Console.WriteLine($"Top students: {per1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {per2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {per3:f2}%");
            Console.WriteLine($"Fail: {per4:f2}%");
            Console.WriteLine($"Average: {per5:f2}");
        }

    }
        }

