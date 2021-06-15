using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Data
{
    public enum BadgeColor
    {
        GoldBadge = 1, BlueBadge, RedBadge
    }
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDescription { get; set; }

        [Required]
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Course> Courses { get; set; }

        //[ForeignKey("Student")]
        //public int StudentId { get; set; }
        //public virtual Student Student { get; set; }

        //[ForeignKey("Course")]
        //public int CourseId { get; set; }
        //public virtual Course Course { get; set; }
    }
}
