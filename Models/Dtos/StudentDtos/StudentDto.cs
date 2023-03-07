#nullable disable warnings
namespace studentsAPI.Models.Dtos.StudentDtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Classroom { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Rg { get; set; }
        public string LegalResponsibleName { get; set; }
        public string AddressStreet { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}