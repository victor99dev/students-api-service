#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    public class TeacherDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}