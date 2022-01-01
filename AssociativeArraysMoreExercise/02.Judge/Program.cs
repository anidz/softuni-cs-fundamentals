﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userCoursePoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> courseUserPoints = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while (command != "no more time")
            {
                string[] input = command.Split(" -> ").ToArray();
                string course = input[1];
                string user = input[0];
                int points = int.Parse(input[2]);

                
                if (!courseUserPoints.ContainsKey(course))
                {
                    courseUserPoints.Add(course, new Dictionary<string, int>());
                }
               
                if (!courseUserPoints[course].ContainsKey(user))
                {
                    courseUserPoints[course][user] = 0;
                }
                
                if (courseUserPoints[course][user] < points)
                {
                    courseUserPoints[course][user] = points;
                }

                
                if (!userCoursePoints.ContainsKey(user))
                {
                    userCoursePoints.Add(user, new Dictionary<string, int>());
                }
                
                if (!userCoursePoints[user].ContainsKey(course))
                {
                    userCoursePoints[user][course] = 0;
                }
               
                if (userCoursePoints[user][course] < points)
                {
                    userCoursePoints[user][course] = points;
                }

                command = Console.ReadLine();
            }

            List<string> result = new List<string>();
            foreach (var kvp in courseUserPoints)
            {
                result.Add($"{kvp.Key}: {kvp.Value.Count()} participants");
                int counter = 0;

                var sortedCourses = kvp.Value.OrderByDescending(x => x.Value).ThenBy(u => u.Key);
                foreach (var item in sortedCourses)
                {
                    counter++;
                    result.Add($"{counter}. {item.Key} <::> {item.Value}");
                }

            }
            result.Add("Individual standings:");
            int count = 0;

            var sortedUsers = userCoursePoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key);
            foreach (var kvp in sortedUsers)
            {
                count++;
                result.Add($"{count}. {kvp.Key} -> {kvp.Value.Values.Sum()}");
            }
            
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
        
    

