namespace SchoolApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public int ProfessorId {  get; set; }
        public Professor Professor { get; set; }
    }
}
