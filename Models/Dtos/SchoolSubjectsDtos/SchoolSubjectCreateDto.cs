#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectsDtos
{
    public class SchoolSubjectCreateDto
    {
        public string Name { get; set; }
        public Guid Teacher { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}