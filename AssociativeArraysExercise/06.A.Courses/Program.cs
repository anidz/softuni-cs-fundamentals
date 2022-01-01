using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.A.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(" : ").ToArray();
                string courseName = inputArr[0];

                if (courseName == "end")
                {
                    break;
                }
                string studentName = inputArr[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var kvp in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }

        }
    }
}
