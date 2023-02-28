namespace wapp1.Models
{
    public class Profession
    {
        public int ProfessionID { get; set; }
        public string? Name { get; set; }
      

        public ICollection<Group>? Groups { get; set; }
    }
}
