﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Student
{
    public class StudentDetail
    {     
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GithubProfile { get; set; }
        public DateTimeOffset EnrollDate { get; set; }
        public virtual List<ProjectListItem> Projects { get; set; }
    }
}
