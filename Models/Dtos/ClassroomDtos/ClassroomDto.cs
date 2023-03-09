#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public bool is_active { get; set; }
    }
}