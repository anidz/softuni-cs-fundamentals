using System;
using System.Collections.Generic;

namespace _04.Students
{
    class StartUp
    {
        
        
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        class Program
        {
            public static void Main(string[] args)
            {
                List<Student> students = new List<Student>();

                string line = Console.ReadLine();
                while (line != "end")
                {
                    string[] tokens = line.Split();

                    string firstName = tokens[0];
                    string lastName = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string city = tokens[3];

                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city,

                    };
                    students.Add(student);
                    line = Console.ReadLine();
                }
                string fiterCity = Console.ReadLine();

                foreach (Student student in students)
                {
                    if (student.City == fiterCity)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                    }
                }
            }
        }
    }
}

