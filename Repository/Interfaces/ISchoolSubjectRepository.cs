using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Repository.Interfaces
{
    public interface ISchoolSubjectRepository
    {
        Task<IEnumerable<SchoolSubjectDto>> GetAll();
        Task<SchoolSubject> GetById(int id);
    }
}