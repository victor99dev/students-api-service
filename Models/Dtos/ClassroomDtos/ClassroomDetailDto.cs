using studentsAPI.Models.Dtos.SchoolSubjectDtos;
using studentsAPI.Models.Dtos.StudentDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomDetailDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public List<StudentDto> students { get; set; }
        public List<SchoolSubjectDto> school_subjects { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}