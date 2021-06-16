using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models
{
   public class ProjectCreate
    {
        [Required]
        [MinLength(5, ErrorMessage ="Please enter at least 5 characters")]
        [MaxLength(100, ErrorMessage ="There are too manay charactes in this field")]
        public string  Projectname { get; set; }

        [MaxLength(10000)]
        public string ProjectDescription { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

    }
}
