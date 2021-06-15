using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Data
{
    public enum CourseType
    {
        web_dev = 1, software_dev, cyber
    }

    // For Cohort web_dev = WD, soft_dev = SD, and cyber = CB

    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        [Display(Name = "Cohort")] // redundant because same name
        public string Cohort { get; set; }
        [Required]
        [Display(Name = "Course Type")]
        public CourseType CourseType { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        [Display(Name ="Start Date [UTC]")]
        public DateTimeOffset StartDate { get; set; }
        [Display(Name ="End Date [UTC]")]
        public DateTimeOffset EndDate { get; set; }
    }
}
