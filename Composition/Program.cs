using Composition.Model;
using System;
using System.Collections.Generic;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            Techer techer = new Techer
            {
                Id = 1,
                Name = "Ibrahim",
                courses = new List<Course>(),
            };
            Student student = new Student
            {
                Id = 1,
                Name = "Omar",
                address = "azaz",
                DateOfBirth = new DateTime(2002, 1, 1),
                subjects = new List<Subject>(),
            };
            Course course = new Course
            {
                Id = 1,
                code = 12002,
                Name = "C# Programming",
                Mark = 100,
                Price = 200m,
                TecherId = techer.Id,
                Techer = techer,
                subjects = new List<Subject>(),
            };

            Subject subject = new Subject
            {
                Id = 1001,
                CourseId = course.Id,
                StudentId = student.Id,
                course = course,
                student = student,
                Mark = 85,
            };

            techer.courses.Add(course);
            student.subjects.Add(subject);
            course.subjects.Add(subject);


            Console.WriteLine(
                  $"courseName : {subject.course.Name}" +
                  $" Techer {subject.course.Techer.Name}" +
                  $" Student Name {subject.student.Name} " +
                  $"Mark {subject.Mark}");
            

        }
    }
}
