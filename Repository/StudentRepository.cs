using studentsAPI.Context;
using studentsAPI.Models.Dtos.StudentDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<StudentDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}