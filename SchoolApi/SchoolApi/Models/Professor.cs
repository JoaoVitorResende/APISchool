namespace SchoolApi.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Aluno> Alunos { get; set; }
    }
}
