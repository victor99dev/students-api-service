#nullable disable warnings
namespace studentsAPI.Models.Entities
{
    public class Student : Base
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Rg { get; set; }
        public string LegalResponsibleName { get; set; }
        public string AddressStreet { get; set; }
        public string PhoneNumber { get; set; }
    }
}