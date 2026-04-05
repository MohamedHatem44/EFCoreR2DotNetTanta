using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Project.Configuration
{
    public class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Fluent API Configuration for Student Entity
            builder.HasKey(s => s.StdId);

            builder.Property(s => s.StdName)
                .HasColumnName("StudentName")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Email)
                .HasColumnName("StudentEmail")
                .HasMaxLength(200)
                .IsRequired();

            builder.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DeptId);
        }
    }
}
