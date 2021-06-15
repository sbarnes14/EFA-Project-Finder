using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [ForeignKey(nameof (Course))]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public string GithubProfile { get; set; }

        public DateTime EnrollDate { get; set; } 

        public virtual IEnumerable<Project> Projects { get; set; }


        //[Required]
        //public int ProjectId { get; set; }

        //[ForeignKey("Project")]
        //public virtual Project Project { get; set; }
    }
}
