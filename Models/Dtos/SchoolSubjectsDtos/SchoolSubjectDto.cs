using studentsAPI.Models.Dtos.TeacherDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectsDtos
{
    public class SchoolSubjectDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TeacherDto Teacher { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}