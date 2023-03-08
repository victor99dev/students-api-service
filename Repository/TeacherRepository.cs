using Microsoft.EntityFrameworkCore;
using studentsAPI.Infrastructure.Common;
using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

#nullable disable warnings
namespace studentsAPI.Repository
{
    public class TeacherRepository : BaseRepository, ITeacherRepository
    {
        private readonly StudentContext _context;
        
        public TeacherRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TeacherDto>> GetAll()
        {
            return await _context.Teachers
                .Select(x => new TeacherDto { 
                    id = x.Id,
                    name = x.Name,
                    created_at = x.CreatedAt,
                    updated_at = x.UpdatedAt,
                    is_active = x.IsActive
                    })
                .ToListAsync();
        }

        public async Task<Teacher> GetById(Guid id)
        {
            return await _context.Teachers
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}