using studentsAPI.Context;
using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Entities;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI.Repository
{
    public class SchoolSubjectRepository : BaseRepository, ISchoolSubjectRepository
    {
        private readonly StudentContext _context;
        
        public SchoolSubjectRepository(StudentContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<SchoolSubjectDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SchoolSubject> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}