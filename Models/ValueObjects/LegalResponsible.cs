namespace studentsAPI.Models.ValueObjects
{
    public class LegalResponsible
    {
        public LegalResponsible(string Name)
        {
            Value = Name;
        }
        public string Value { get; set; }
    }
}