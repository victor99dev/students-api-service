#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    public class TeacherUpdateDto
    {
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}