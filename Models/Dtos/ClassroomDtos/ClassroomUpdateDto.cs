#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    public class ClassroomUpdateDto
    {
        public string name { get; set; }
        public Guid? students_id { get; set; }
        public Guid? school_subjects_id { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}