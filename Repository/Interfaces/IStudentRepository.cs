using studentsAPI.Models.Dtos.StudentDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Repository.Interfaces
{
    public interface IStudentRepository : IBaseRepository
    {
        Task<IEnumerable<StudentDto>> GetAll();
        Task<Student> GetById(int id);
    }
}