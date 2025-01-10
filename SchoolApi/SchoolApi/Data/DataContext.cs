using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professor>()
                .HasData(
                    new List<Professor>() {
                        new Professor()
                        {
                            Id = 1,
                            Name = "Joao"
                        },
                        new Professor()
                        {
                            Id = 2,
                            Name = "Lucas"
                        },
                        new Professor()
                        {
                            Id = 3,
                            Name = "Heitor"
                        }
                    }
                );
            modelBuilder.Entity<Aluno>()
               .HasData(
                   new List<Aluno>() {
                        new Aluno()
                        {
                            Id = 1,
                            Name = "Alex",
                            LastName = "Fagundes",
                            ProfessorId = 1
                        },
                        new Aluno()
                        {
                            Id = 2,
                            Name = "Lucas",
                            LastName = "Abreu",
                            ProfessorId = 2
                        },
                        new Aluno()
                        {
                            Id = 3,
                            Name = "Heitor",
                            LastName = "Nogueira",
                            ProfessorId = 3
                        }
                   }
               );
        }
    }
}
