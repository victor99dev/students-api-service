using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentsAPI.Models.Entities;

namespace studentsAPI.Infrastructure.EntityConfig
{
   public class SchoolSubjectMap : BaseMap<SchoolSubject>
    {
        public SchoolSubjectMap() : base("SchoolSubjects")
        {}

        public override void Configure(EntityTypeBuilder<SchoolSubject> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.TeacherId)
                .HasColumnName("teacher_id")
                .IsRequired();

            builder.HasOne(x => x.Teacher)
                .WithMany()
                .HasForeignKey(x => x.TeacherId);
        }
    }
}