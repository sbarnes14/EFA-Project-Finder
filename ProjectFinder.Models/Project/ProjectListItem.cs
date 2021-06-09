using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Models
{
    public class ProjectListItem
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset Createdutc { get; set; }
    }
}
