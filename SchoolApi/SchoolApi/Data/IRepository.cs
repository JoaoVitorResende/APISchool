using SchoolApi.Models;

namespace SchoolApi.Data
{
    public interface IRepository
    {
        void Add<t>(t entity) where t : class;
        void Update<t>(t entity) where t : class;
        void Delete<t>(t entity) where t : class;
        Task<bool> SaveChangesAsync();
        Task<Aluno[]> GetAllAlunosAsync(bool isProfessorIncluido);
        Task<Aluno[]> GetAlunosAsyncByProfessorId(int professorId, bool isProfessorIncluido);
        Task<Aluno[]> GetAlunoAsyncById(int alunoId, bool isProfessorIncluido);
        Task<Professor[]> GetAllProfessoresAsync(bool isAlunoIncluido);
        Task<Professor> GetProfessorAsyncById(int professorId, bool isAlunoIncluido);
    }
}
