#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class SchoolSubject : Base
    {
        public string Name { get; set; }
        public Teacher TeacherId { get; set; }
    }
}