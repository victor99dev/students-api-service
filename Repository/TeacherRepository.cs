using Microsoft.EntityFrameworkCore;
using studentsAPI.Context;
using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

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
                    Id = x.Id,
                    Name = x.Name,
                    IsActive = x.IsActive
                    })
                .ToListAsync();
        }

        public Task<Teacher> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}