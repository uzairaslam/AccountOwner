using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.IsRegularStudent).HasDefaultValue(true);

            builder.HasData(
                    new Student
                    {
                        StudentId = 1,
                        Name = "John Doe",
                        Age = 30
                    },
                    new Student
                    {
                        StudentId = 2,
                        Name = "Jane Doe",
                        Age = 25
                    },
                    new Student
                    {
                        StudentId = 3,
                        Name = "Mike Miles",
                        Age = 28
                    }
                );
        }
    }
}
