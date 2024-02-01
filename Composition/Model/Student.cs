using System;
using System.Collections.Generic;

namespace Composition.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public List<Study>  studies { get; set; }
    }
}
