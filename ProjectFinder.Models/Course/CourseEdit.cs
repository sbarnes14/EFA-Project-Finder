using ProjectFinder.Data;
using ProjectFinder.Models.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Course
{
    public class CourseEdit
    {
        public int CourseId { get; set; }
        public string Cohort { get; set; }
        public CourseType CourseType { get; set; }
        [Display(Name = "Start Date [UTC]")]
        public DateTimeOffset StartDate { get; set; }
        [Display(Name = "End Date [UTC]")]
        public DateTimeOffset EndDate { get; set; }
    }
}
