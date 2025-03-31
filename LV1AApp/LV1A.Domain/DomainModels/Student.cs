using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1A.Domain.DomainModels
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public long? Index { get; set; }
        public DateTime? EnrollmentYear { get; set; }
        public virtual ICollection<Enrollment>? Enrolments { get; set; }

    }
}
