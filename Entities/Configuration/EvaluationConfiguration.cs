using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.HasData
            (
                new Evaluation
                {
                    Id = 1,//Guid.NewGuid(),
                    Grade = 5,
                    AdditionalExplanation = "First test...",
                    StudentId = 1
                },
                new Evaluation
                {
                    Id = 2,//Guid.NewGuid(),
                    Grade = 4,
                    AdditionalExplanation = "Second test...",
                    StudentId = 1
                },
                new Evaluation
                {
                    Id = 3,//Guid.NewGuid(),
                    Grade = 3,
                    AdditionalExplanation = "First test...",
                    StudentId = 2
                },
                new Evaluation
                {
                    Id = 4,//Guid.NewGuid(),
                    Grade = 2,
                    AdditionalExplanation = "Last test...",
                    StudentId = 3
                }
            );
        }
    }
}
