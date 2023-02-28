namespace wapp1.Models
{
    public class Evaluation
    {
        public int EvaluationID { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int Number { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }

        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
