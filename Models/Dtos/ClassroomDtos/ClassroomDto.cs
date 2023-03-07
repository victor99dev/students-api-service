using studentsAPI.Models.Dtos.SchoolSubjectsDtos;
using studentsAPI.Models.Dtos.StudentDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<StudentDto> Students { get; set; }
        public List<SchoolSubjectDto> SchoolSubjects { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}