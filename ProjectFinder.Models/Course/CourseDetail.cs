using ProjectFinder.Data;
using ProjectFinder.Models.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Course
{
    // This whole class is not currently being used bc line 17 throws error bc Student is also a namespace in ProjectFinder.Models - Opted to use Course in Service for GET Method
    public class CourseDetail
    {
        public int CourseId { get; set; }
        public string Cohort { get; set; }
        public CourseType CourseType { get; set; }
        public virtual IEnumerable<StudentDetail> Students { get; set; }
        [Display(Name = "Start Date [UTC]")]
        public DateTimeOffset StartDate { get; set; }
        [Display(Name = "End Date [UTC]")]
        public DateTimeOffset EndDate { get; set; }
    }
}
