using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArhitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timePerOneProject = 3;
            int timeNeedForAllProjects = numberOfProjects * timePerOneProject;
            Console.WriteLine($"The architect {nameOfTheArhitect} will need {timeNeedForAllProjects} hours to complete { numberOfProjects} project/s.");
        }
    }
}
