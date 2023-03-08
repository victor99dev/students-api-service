using System.Runtime.Serialization;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    [DataContract]
    public class TeacherCreateDto
    {
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public bool is_active { get; set; }
    }
}