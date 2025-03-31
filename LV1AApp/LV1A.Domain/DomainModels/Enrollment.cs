using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1A.Domain.DomainModels
{
    public class Enrollment
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? DateEnrolled { get; set; }
        public bool? ReEnrolled { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? CourseId { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
