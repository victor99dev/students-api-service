using System.Runtime.Serialization;

#nullable disable warnings
namespace studentsAPI.Models.Dtos.SchoolSubjectDtos
{
    [DataContract]
    public class SchoolSubjectUpdateDto
    {
        public string name { get; set; }
        public Guid teacher { get; set; }
        public DateTime updated_at { get; set; }
        public bool is_active { get; set; }
    }
}