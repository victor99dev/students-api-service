using studentsAPI.Models.Dtos.TeacherDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Repository.Interfaces
{
    public interface ITeacherRepository : IBaseRepository
    {
        Task<IEnumerable<TeacherDto>> GetAll();
        Task<Teacher> GetById(int id);
    }
}