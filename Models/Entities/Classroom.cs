#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class Classroom : Base
    {
        public string Name { get; set; }
        public Guid? StudentsId { get; set; }
        public Student? Students { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
    }
}