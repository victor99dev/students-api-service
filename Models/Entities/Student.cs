
using studentsAPI.Models.ValueObjects;

#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class Student : Base
    {
        public string Name { get; set; }
        public Classroom ClassroomId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Rg { get; set; }
        public LegalResponsible LegalResponsibleName { get; set; }
        public Address AddressStreet { get; set; }
        public string PhoneNumber { get; set; }
    }
}