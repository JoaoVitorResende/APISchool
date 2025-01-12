
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Data
{
    public class Repository : IRepository
    {
        public DataContext _context { get; }
        public Repository(DataContext context) => _context = context;
       
        public void Add<t>(t entity) where t : class => _context.Add(entity);
       
        public void Delete<t>(t entity) where t : class => _context.Remove(entity);
        
        public void Update<t>(t entity) where t : class => _context.Update(entity);

        public async Task<bool> SaveChangesAsync() => (await _context.SaveChangesAsync() > 0);

        public async Task<Aluno[]> GetAllAlunosAsync(bool isProfessorIncluido = false)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if(isProfessorIncluido)
            {
                query = query.Include(aluno => aluno.Professor);
            }
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Aluno[]> GetAlunosAsyncByProfessorId(int professorId, bool isProfessorIncluido)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (isProfessorIncluido)
                query = query.Include(aluno => aluno.Professor);
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id).Where(aluno => aluno.ProfessorId == professorId);
            return await query.ToArrayAsync();
        }
        public async Task<Aluno> GetAlunoAsyncById(int alunoId, bool isProfessorIncluido)
        {
            IQueryable<Aluno> query = _context.Alunos;
            if (isProfessorIncluido)
                query = query.Include(aluno => aluno.Professor);
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id).Where(aluno => aluno.Id == alunoId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Professor[]> GetAllProfessoresAsync(bool isAlunoIncluido)
        {
            IQueryable<Professor> query = _context.Professores;
            if (isAlunoIncluido)
                query = query.Include(professor => professor.Alunos);
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Professor> GetProfessorAsyncById(int professorId, bool isAlunoIncluido = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if (isAlunoIncluido)
                query = query.Include(professor => professor.Alunos);
            query = query.AsNoTracking().OrderBy(aluno => aluno.Id).Where(Professor => Professor.Id == professorId);
            return await query.FirstOrDefaultAsync();
        }
    }
}
