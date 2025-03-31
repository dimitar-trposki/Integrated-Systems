using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1A.Domain.DomainModels
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Semeter { get; set; }
        public virtual ICollection<Lecture>? Lectures { get; set; }
        public virtual ICollection<Enrollment>? Enrolments { get; set; }
    }
}
