using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Data
{
    public enum BadgeColor
    {
        GoldBadge = 1, BlueBadge, RedBadge
    }
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDescription { get; set; }

        [Required]
        public int Students { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public string GitHubRepo { get; set; }

        [Required]
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
