#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectDtos
{
    public class SchoolSubjectCreateDto
    {
        public string name { get; set; }
        public Guid teacher_id { get; set; }
        public DateTime created_at { get; set; }
        public bool is_active { get; set; }
    }
}