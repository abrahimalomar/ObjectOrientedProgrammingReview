namespace Composition.Model
{
    public class Study
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }

    }
}
