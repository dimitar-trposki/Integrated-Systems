using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1A.Domain.Identity
{
    public class CourseApplicationUser : IdentityUser
    {
        public DateTime? DateOfBirth { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
