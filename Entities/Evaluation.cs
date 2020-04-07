using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Evaluation
    {
        [Column("EvaluationId")]
        public int Id { get; set; }

        [Required]
        public int Grade { get; set; }

        public string AdditionalInformation { get; set; }

        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
    }
}
