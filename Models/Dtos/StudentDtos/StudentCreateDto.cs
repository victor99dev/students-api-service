#nullable disable warnings
namespace studentsAPI.Models.Dtos.StudentDtos
{
    public class StudentCreateDto
    {
        public string name { get; set; }
        public Guid? classroom_id { get; set; }
        public DateTime date_of_birth { get; set; }
        public string? rg { get; set; }
        public string legal_responsible_name { get; set; }
        public string address_street { get; set; }
        public DateTime created_at { get; set; }
        public bool is_active { get; set; }
    }
}