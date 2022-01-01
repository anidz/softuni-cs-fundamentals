using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var commands = Console.ReadLine().Split(':').ToArray();
                var firstCmd = commands[0];
                if (firstCmd == "course start")
                {
                    break;
                }
                if (firstCmd == "Add")
                {
                    string currLecture = commands[1];
                    if (!lessons.Contains(currLecture))
                    {
                        lessons.Add(currLecture);
                    }
                }
                else if (firstCmd == "Insert")
                {
                    string currLecture = commands[1];
                    if (!lessons.Contains(currLecture))
                    {
                        int givenIndexFromCmd = int.Parse(commands[2]);
                        if (givenIndexFromCmd < lessons.Count && givenIndexFromCmd >= 0)
                        {
                            lessons.Insert(givenIndexFromCmd, currLecture);
                        }
                    }
                }
                else if (firstCmd == "Remove")
                {
                    string currLecture = commands[1];
                    lessons.Remove(currLecture);
                    lessons.Remove($"{currLecture}-Exercise");
                }
                else if (firstCmd == "Swap")
                {
                    string lessonOneTitle = commands[1];
                    string lessonTwoTitle = commands[2];
                    int indexOfLessonOne = lessons.IndexOf(lessonOneTitle);
                    int indexOfLessonTwo = lessons.IndexOf(lessonTwoTitle);
                    if (indexOfLessonOne != -1 && indexOfLessonTwo != -1)
                    {
                        lessons[indexOfLessonOne] = lessonTwoTitle;
                        lessons[indexOfLessonTwo] = lessonOneTitle;
                        if (indexOfLessonOne + 1 < lessons.Count && lessons[indexOfLessonOne + 1] == $"{lessonOneTitle}-Exercise")
                        {
                            lessons.RemoveAt(indexOfLessonOne + 1);
                            indexOfLessonOne = lessons.IndexOf(lessonOneTitle);
                            lessons.Insert(indexOfLessonOne + 1, $"{lessonOneTitle}-Exercise");
                        }
                        if (indexOfLessonTwo + 1 < lessons.Count && lessons[indexOfLessonTwo + 1] == $"{lessonTwoTitle}-Exercise")
                        {
                            lessons.RemoveAt(indexOfLessonTwo + 1);
                            indexOfLessonTwo = lessons.IndexOf(lessonTwoTitle);
                            lessons.Insert(indexOfLessonTwo + 1, $"{lessonTwoTitle}-Exercise");
                        }
                    }
                }
                else if (firstCmd == "Exercise")
                {
                    string currentLection = commands[1];
                    int index = lessons.IndexOf(currentLection);
                    if (lessons.Contains(currentLection) && !lessons.Contains($"{currentLection}-Exercise"))
                    {
                        lessons.Insert(index + 1, $"{currentLection}-Exercise");
                    }
                    else if (!lessons.Contains(currentLection))
                    {
                        lessons.Add(currentLection);
                        lessons.Add($"{currentLection}-Exercise");
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
    }

