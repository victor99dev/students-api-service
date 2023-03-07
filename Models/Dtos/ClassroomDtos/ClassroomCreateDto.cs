using studentsAPI.Models.Dtos.SchoolSubjectsDtos;
using studentsAPI.Models.Dtos.StudentDtos;

#nullable disable warnings

namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomCreateDto
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}