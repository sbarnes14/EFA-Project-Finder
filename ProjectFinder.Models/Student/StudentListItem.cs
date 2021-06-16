using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models.Student
{
    public class StudentListItem
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset EnrollDate { get; set; }
    }
}
