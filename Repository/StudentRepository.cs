using Microsoft.EntityFrameworkCore;
using studentsAPI.Infrastructure.Common;
using studentsAPI.Models.Dtos.StudentDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

#nullable disable warnings
namespace studentsAPI.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentDto>> GetAll()
        {
            return await _context.Students
                .Select(x => new StudentDto {
                    id = x.Id,
                    name = x.Name,
                    is_active = x.IsActive
                    })
                .ToListAsync();
        }

        public async Task<Student> GetById(Guid id)
        {
             return await _context.Students
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}