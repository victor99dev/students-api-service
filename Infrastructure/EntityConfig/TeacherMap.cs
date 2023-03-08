using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentsAPI.Models.Entities;

namespace studentsAPI.Infrastructure.EntityConfig
{
    public class TeacherMap : BaseMap<Teacher>
    {
        public TeacherMap() : base("Teachers")
        {}

        public override void Configure(EntityTypeBuilder<Teacher> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();
        }

    }
}