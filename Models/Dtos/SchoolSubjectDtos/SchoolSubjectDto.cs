using studentsAPI.Models.Dtos.TeacherDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectDtos
{
    public class SchoolSubjectDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public TeacherDto teacher { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}