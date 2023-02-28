namespace wapp1.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public int? ProfessionId { get; set; }

        public Profession? Profession { get; set; }
        public ICollection<Student>? Students { get; set; }
       
    }
}
