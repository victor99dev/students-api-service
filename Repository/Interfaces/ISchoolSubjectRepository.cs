using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Repository.Interfaces
{
    public interface ISchoolSubjectRepository : IBaseRepository
    {
        Task<IEnumerable<SchoolSubjectDto>> GetAll();
        Task<SchoolSubject> GetById(Guid id);
    }
}