
#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomUpdateDto
    {
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}