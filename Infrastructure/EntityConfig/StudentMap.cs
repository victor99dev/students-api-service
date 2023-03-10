using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentsAPI.Models.Entities;


namespace studentsAPI.Infrastructure.EntityConfig
{
    public class StudentMap : BaseMap<Student>
    {
        public StudentMap() : base("Students")
        {}

        public override void Configure(EntityTypeBuilder<Student> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.DateOfBirth)
                .HasColumnName("date_of_birth")
                .IsRequired();

            builder.Property(x => x.Rg)
                .HasColumnName("rg");

            builder.Property(x => x.LegalResponsibleName)
                .HasColumnName("legal_responsible_name");

            builder.Property(x => x.AddressStreet)
                .HasColumnName("address_street");

            builder.Property(x => x.PhoneNumber)
               .HasColumnName("phone_number");
        }
    }
}