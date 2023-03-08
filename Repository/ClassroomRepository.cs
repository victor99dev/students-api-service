
using studentsAPI.Context;
using studentsAPI.Models.Dtos.ClassroomDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Repository
{
    public class ClassroomRepository : BaseRepository, IClassroomRepository
    {
        private readonly StudentContext _context;

        public ClassroomRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<ClassroomDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Classroom> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}