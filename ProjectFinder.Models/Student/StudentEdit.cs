using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Student
{
    public class StudentEdit
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GithubProfile { get; set; }
        public DateTimeOffset EnrollDate { get; set; }
        public virtual IEnumerable<ProjectListItem> Projects { get; set; }
    }
}
