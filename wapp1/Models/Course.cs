namespace wapp1.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? Name { get; set; }
        public int? InstructorID { get; set; }
        public int? StudentId { get; set; }


        public Instructor? Instructor { get; set; }
        public Student? Student { get; set; }
    }
}
