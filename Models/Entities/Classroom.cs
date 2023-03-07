#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class Classroom
    {
        public string Name { get; set; }
        public List<Student?> Students { get; set; }
    }
}