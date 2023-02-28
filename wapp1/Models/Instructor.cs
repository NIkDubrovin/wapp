namespace wapp1.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string? Name { get; set; }
        

        public ICollection<Course>? Courses { get; set; }
    }
}
