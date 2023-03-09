using studentsAPI.Models.Dtos.ClassroomDtos;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.StudentDtos
{
    public class StudentDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public bool is_active { get; set; }
    }
}