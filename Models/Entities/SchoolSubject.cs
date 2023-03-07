#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class SchoolSubject : Base
    {
        public string Name { get; set; }

        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}