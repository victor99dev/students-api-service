#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomCreateDto
    {
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public bool is_active { get; set; }
    }
}