using Microsoft.EntityFrameworkCore;
using studentsAPI.Infrastructure.Common;
using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

#nullable disable warnings
namespace studentsAPI.Repository
{
    public class SchoolSubjectRepository : BaseRepository, ISchoolSubjectRepository
    {
        private readonly StudentContext _context;

        public SchoolSubjectRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SchoolSubjectDto>> GetAll()
        {
            return await _context.SchoolSubjects
                .Select(x => new SchoolSubjectDto {
                    id = x.Id,
                    name = x.Name,
                    teacher_name = x.Teacher.Name,
                    is_active = x.IsActive
                    })
                .ToListAsync();
        }

        public async Task<SchoolSubject> GetById(Guid id)
        {
            return await _context.SchoolSubjects
                .Include(x => x.Teacher)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}