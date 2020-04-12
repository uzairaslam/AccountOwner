using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(s => new { s.StudentId, s.SubjectId });

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.StudentId);

            builder.HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectId);

            builder.HasData
            (
                new StudentSubject
                {
                    StudentId = 1,
                    SubjectId = 1
                },
                new StudentSubject
                {
                    StudentId = 1,
                    SubjectId = 2
                },
                new StudentSubject
                {
                    StudentId = 1,
                    SubjectId = 3
                },
                new StudentSubject
                {
                    StudentId = 2,
                    SubjectId = 4
                },
                new StudentSubject
                {
                    StudentId = 2,
                    SubjectId = 1
                },
                new StudentSubject
                {
                    StudentId = 3,
                    SubjectId = 4
                }
            );
        }
    }
}
