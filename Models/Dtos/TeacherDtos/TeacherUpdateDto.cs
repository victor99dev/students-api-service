using System.Runtime.Serialization;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.TeacherDtos
{
    [DataContract]
    public class TeacherUpdateDto
    {
        public string name { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}