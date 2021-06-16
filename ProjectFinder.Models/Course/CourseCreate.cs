using ProjectFinder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Course
{
    public class CourseCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Cohort must be at least 2 characters.")] // Min length here
        [MaxLength(20, ErrorMessage ="Cohort must be no more than 20 characters.")] // Max length here
        public string Cohort { get; set; }
        public CourseType CourseType { get; set; }
        public DateTimeOffset StartDate { get; set; }
    }
}
