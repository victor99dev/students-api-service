namespace studentsAPI.Models.ValueObjects
{
    public class Address
    {
        public Address(string Street)
        {
            Value = Street;
        }
        public string Value { get; set; }
    }
}