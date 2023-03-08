#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    public class TeacherDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public bool is_active { get; set; }
    }
}