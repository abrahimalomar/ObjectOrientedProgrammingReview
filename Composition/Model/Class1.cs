using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Model
{
  public class Techer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> courses { get; set; } 
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int code { get; set; }
        public int Mark { get; set; }
        public decimal Price { get; set; }
        public int TecherId { get; set; }
        public Techer Techer { get; set; }
        public List<Subject> subjects { get; set; }

    }
    public class Subject
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public List<Subject> subjects { get; set; }
    }
}
