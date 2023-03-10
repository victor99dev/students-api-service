using studentsAPI.Models.Dtos.ClassroomDtos;
using studentsAPI.Models.Entities;

namespace studentsAPI.Repository.Interfaces
{
    public interface IClassroomRepository : IBaseRepository
    {
        Task<IEnumerable<ClassroomDto>> GetAll();
        Task<Classroom> GetById(Guid id);
    }
}