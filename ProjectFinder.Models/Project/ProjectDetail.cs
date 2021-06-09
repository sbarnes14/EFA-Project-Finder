using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models
{
    public class ProjectDetail
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModfiedUtc { get; set; }

    }
}
