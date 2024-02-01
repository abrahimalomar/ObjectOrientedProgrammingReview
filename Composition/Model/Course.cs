using System.Collections.Generic;

namespace Composition.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int code { get; set; }
        public int Mark { get; set; }
        public decimal Price { get; set; }
        public int TecherId { get; set; }
        public Techer Techer { get; set; }
        public List<Study> studies { get; set; }

    }
}
