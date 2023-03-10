using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentsAPI.Models.Entities;

namespace studentsAPI.Infrastructure.EntityConfig
{
    public class ClassroomMap : BaseMap<Classroom>
    {
        public ClassroomMap() : base("Classrooms")
        {}

        public override void Configure(EntityTypeBuilder<Classroom> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.SchoolSubjectId)
                .HasColumnName("school_subject_id");

            builder.HasOne(x => x.SchoolSubject)
                .WithMany()
                .HasForeignKey(x => x.SchoolSubjectId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.StudentsId)
                .HasColumnName("student_id");

            builder.HasOne(x => x.Students)
                .WithMany()
                .HasForeignKey(x => x.StudentsId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}