using ProjectFinder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Course
{
    public class CourseList
    {
        public int CourseId { get; set; }
        public string Cohort { get; set; }
        public CourseType CourseType { get; set; }
        [Display(Name ="Start Date [UTC]")]
        public DateTimeOffset StartDate { get; set; }
    }
}
