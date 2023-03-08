using System.Runtime.Serialization;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.ClassroomDtos
{
    [DataContract]
    public class ClassroomUpdateDto
    {
        public string name { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}