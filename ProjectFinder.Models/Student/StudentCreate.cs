using System.ComponentModel.DataAnnotations;

namespace ProjectFinder.Models
{
    public class StudentCreate
    {
        //maybe dont need SID in this class?
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


    }
}
