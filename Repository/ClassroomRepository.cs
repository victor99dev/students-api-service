using Microsoft.EntityFrameworkCore;
using studentsAPI.Infrastructure.Common;
using studentsAPI.Models.Dtos.ClassroomDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

#nullable disable warnings
namespace studentsAPI.Repository
{
    public class ClassroomRepository : BaseRepository, IClassroomRepository
    {
        private readonly StudentContext _context;

        public ClassroomRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClassroomDto>> GetAll()
        {
            return await _context.Classrooms
                .Select(x => new ClassroomDto {
                    id = x.Id,
                    name = x.Name,
                    is_active = x.IsActive
                    })
                .ToListAsync();
        }

        public async Task<Classroom> GetById(Guid id)
        {
            return await _context.Classrooms
                .Include(x => x.Students)
                .Include(x => x.SchoolSubject)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}