namespace wapp1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int? GroupId { get; set; }

        public ICollection<Evaluation>? Evaluations { get; set; }
        public ICollection<Course>? Courses { get; set; }

    }
}
