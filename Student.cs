using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergachevTARpv23
{
    public class Student
    {
        private static int _idCounter = 1;

        public int ID { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Dictionary<string, List<int>> Courses { get; private set; }

        public Student(string lastName, string firstName, int age)
        {
            ID = _idCounter++;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Courses = new Dictionary<string, List<int>>();
        }

        public void AddCourse(string course)
        {
            if (!Courses.ContainsKey(course))
            {
                Courses[course] = new List<int>();
            }
        }

        public void AddGrade(string course, int grade)
        {
            if (Courses.ContainsKey(course))
            {
                Courses[course].Add(grade);
            }
            else
            {
                Console.WriteLine($"Course {course} does not exist for student {LastName}.");
            }
        }

        public double GetAverageGrade(string course)
        {
            if (Courses.ContainsKey(course))
            {
                return Courses[course].Average();
            }
            else
            {
                Console.WriteLine($"Course {course} does not exist for student {LastName}.");
                return 0;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}");
            foreach (var course in Courses)
            {
                Console.WriteLine($"Course: {course.Key}, Grades: {string.Join(", ", course.Value)}");
            }
        }
    }
}
