using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //[Required]
        //public string GithubProfile { get; set; }

        //[Required]
        public DateTime EnrollDate { get; set; }

        //[Required]
        //public int ProjectId { get; set; }

        //[ForeignKey("Project")]
        //public virtual Project Project { get; set; }

        //[ForeignKey("Course")]
        //public int CourseId { get; set; }
        //public virtual Course Course { get; set; }
    }
}
